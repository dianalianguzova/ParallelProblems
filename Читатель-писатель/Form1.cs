using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Читатель_писатель
{
    public partial class Form1 : Form
    {
        private Thread[] readers;
        private Thread writer;

        private int[] rsSleepTime;
        private int wsleepTime;

        Semaphore rc, sem; //rc - контроль за общим ресурсом, sem - контроль за доступом к бд
        int countThreads = 0;

        Graphics g;
        SolidBrush brush;
        Pen pen;
        int x_BD, y_BD; //координаты БД
        int[,] coords=new int[4,2]; //координаты читателей и писателей
        const int s_c = 30; //размер круга
        const int startX = 200;
        int sleep;
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.DoubleBuffered = true; //для плавной отрисовки

            readers = new Thread[3];
            rsSleepTime = new int[3];

            rc = new Semaphore(1);
            sem = new Semaphore(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < readers.Length; i++) { 
                readers[i] = new Thread(() => readersRead(i));
            }
            writer = new Thread(writerWrite);

            rsSleepTime[0] = r1TrackBar.Value * 500;
            rsSleepTime[1] = r2TrackBar.Value * 500;
            rsSleepTime[2] = r3TrackBar.Value * 500;
            wsleepTime = wTrackBar.Value * 500;

            pen = new Pen(Color.Black, 5);

            setCoords();
            x_BD = 350; y_BD = 30;
        }

        private void readersRead(int i) //читает из бд
        {
            while (true)
            {
                rc.wait(i);
                countThreads++; //увеличение читателей в бд
                if (countThreads == 1)
                {
                    sem.wait(i);
                    if (writer.ThreadState == ThreadState.WaitSleepJoin) pushMessage("Писатель ожидает доступа к БД");
                }
                rc.signal();

                toBD(i);
                pushMessage("Читатель " + (i + 1) + " читает");
                Thread.Sleep(1000);
                fromBD(i);

                rc.wait(i);

                countThreads--;
                if (countThreads == 0) sem.signal();

                rc.signal();

                Thread.Sleep(rsSleepTime[i]);
            }
        }

        private void writerWrite() //пишет в бд
        {
            while (true)
            {
                sem.wait(3); //доступ закрыт для читателей
                for (int i = 0; i < 3; i++)
                {
                    if (readers[i].ThreadState == ThreadState.WaitSleepJoin) pushMessage("Читатель " + (i + 1) + " ожидает доступа к БД");
                }

                toBD(3);
                pushMessage("Писатель делает запись в БД");
                Thread.Sleep(1000);
                fromBD(3);
                sem.signal();

                Thread.Sleep(wsleepTime);
            }

        }
        private void toBD(int numC) //numC - номер круга 
        {
            while (coords[numC, 0] != (x_BD + 50))
                this.Invoke((MethodInvoker)delegate
                {
                    coords[numC, 0] += 4; // Меняется координата x
                    this.Invalidate();
                    this.Update();
                });
        }

        private void fromBD(int numC)
        {
            while (coords[numC, 0] != startX)
                this.Invoke((MethodInvoker)delegate
                { 
                    coords[numC, 0] -= 4; // Меняется координата x
                    this.Invalidate();
                    this.Update();
                });
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            for (int i = 0; i < 3; i++)
            {
                drawReader(coords[i,0], coords[i,1]);
            }
            drawWriter( coords[3,0], coords[3,1]);
            drawBD(x_BD, y_BD);
        }
        private void drawReader(int x, int y)
        {
            pen.Color = Color.DarkSlateBlue;
            brush = new SolidBrush(Color.LightBlue);
            g.FillEllipse(brush, new Rectangle(x, y, s_c, s_c));
            g.DrawEllipse(pen, x, y, s_c, s_c);
        }

        private void drawWriter(int x1, int y1)
        {
            pen.Color = Color.DarkRed;
            brush = new SolidBrush(Color.LightCoral);
            g.FillEllipse(brush, new Rectangle(x1, y1, s_c, s_c));
            g.DrawEllipse(pen, x1, y1, s_c, s_c);
        }

        private void drawBD(int x2, int y2)
        {
            pen.Color = Color.DarkSlateGray;
            Rectangle rect = new Rectangle(x2, y2, 130, 410);
            g.DrawRectangle(pen, rect);
        }

        private void pushMessage(string message)
        {
            stateListBox.Invoke((MethodInvoker)delegate
            {
                stateListBox.Items.Add(message);
                stateListBox.TopIndex = stateListBox.Items.Count - 1;
            });
        }

       private void startR(ref Thread t, int num)
        {
            if (!readers[num].IsAlive || readers[num].ThreadState == ThreadState.Aborted)
            {
                readers[num] = new Thread(new ThreadStart(() => readersRead(num)));
                pushMessage("Читатель " + (num+1) + " начал выполнение");
                readers[num].Start();
                ostButton.Enabled = true;
            }
        }

        private void startr1_Click(object sender, EventArgs e)
        {
            startR(ref readers[0], 0);
        }

        private void startr2_Click(object sender, EventArgs e)
        {
            startR(ref readers[1], 1);
        }

        private void startr3_Click(object sender, EventArgs e)
        {
            startR(ref readers[2], 2);
        }

        private void startw_Click(object sender, EventArgs e)
        {
            if (!writer.IsAlive || writer.ThreadState == ThreadState.Aborted)
            {
                writer = new Thread(new ThreadStart(writerWrite));
                pushMessage("Писатель начал выполнение");
                writer.Start();
                ostButton.Enabled = true;
            }
        }
        private void abortReader(int i)
        {         
            if (readers[i].ThreadState == ThreadState.Suspended) readers[i].Resume();
            pushMessage("Читатель " + (i + 1) + " завершил работу");
            readers[i].Abort();
        }

        private void abortWriter()
        {
            if (writer.ThreadState == ThreadState.Suspended) writer.Resume();
            pushMessage("Писатель завершил работу");
            writer.Abort();

        }

        private void ostButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (readers[i].IsAlive) abortReader(i);      
            }

            if (writer.IsAlive) abortWriter();
                    
            this.Invoke((MethodInvoker)delegate
            {
                setCoords();
                this.Invalidate();
                this.Update();
                rc = new Semaphore(1);
                sem = new Semaphore(1);
                countThreads = 0;
            });
        }

        private void pauser1_Click(object sender, EventArgs e)
        {
            pauseR(ref readers[0], 0);

        }      
        private void pauser2_Click(object sender, EventArgs e)
        {
            pauseR(ref readers[1], 1);
        }

        private void pauser3_Click(object sender, EventArgs e)
        {
            pauseR(ref readers[2], 2);
        }

        private void pausew_Click(object sender, EventArgs e)
        {
            if (writer.IsAlive)
            {
                if (writer.ThreadState == ThreadState.Suspended)
                {
                    pushMessage("Писатель возобновил работу");
                    writer.Resume();
                }
                else
                {
                    pushMessage("Писатель приостановил работу");
                    writer.Suspend();
                }
            }
        }

        private void pauseR(ref Thread t, int num)
        {
            if (t.IsAlive)
            {
                if (t.ThreadState == ThreadState.Suspended)
                {
                    pushMessage("Читатель " + (num + 1) + " возобновил работу");
                    t.Resume();
                }
                else
                {
                    pushMessage("Читатель " + (num + 1) + " приостановил работу");
                    t.Suspend();
                }
            }
        }
        private void setCoords()
        {
            coords[0, 0] = 200; coords[0, 1] = 50;  //читатель 1
            coords[1, 0] = 200; coords[1, 1] = 160; //читатель 2
            coords[2, 0] = 200; coords[2, 1] = 270; //читатель 3
            coords[3, 0] = 200; coords[3, 1] = 390; //писатель
        }

        private void r1TrackBar_Scroll(object sender, EventArgs e)
        {
            rsSleepTime[0] = 5500 - (r1TrackBar.Value * 500);
        }

        private void r2TrackBar_Scroll(object sender, EventArgs e)
        {
            rsSleepTime[1] = 5500 - (r2TrackBar.Value * 500);
        }

        private void r3TrackBar_Scroll(object sender, EventArgs e)
        {
            rsSleepTime[2] = 5500 - (r3TrackBar.Value * 500);
        }

        private void wTrackBar_Scroll(object sender, EventArgs e)
        {
            wsleepTime = 5500 - (wTrackBar.Value * 500);
        }
    }
}
