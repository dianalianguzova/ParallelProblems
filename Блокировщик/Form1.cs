using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Diagnostics.Eventing.Reader;

namespace Блокировщик
{
    public partial class Form1 : Form
    {
        private List<string> Ls; 
        private Thread creater;
        private Thread counter;
        private bool isLock = false; //блокирующая переменная
        private int strNum = 0;
        private int readNum = 0;
        private int sleepTimeCreater;
        private int sleepTimeCounter;

        public Form1()
        {
            InitializeComponent();
            sleepTimeCounter = sTrackBar.Value * 500;
            sleepTimeCreater = fTrackBar.Value * 500;
            creater = new Thread(createString);
            counter = new Thread(countSym); 
            Ls = new List<string>();
        }

        public void createString()
        {
            while (true)
            {
                if (isLock == false) //критическая секция
                {
                    isLock = true;
                    string L = Creater.getNewString();
                    Ls.Add(L);
                    strNum++;
                    fListBox.Invoke((MethodInvoker)delegate {
                        fListBox.Items.Add((strNum) + ". " + L);
                        fListBox.TopIndex = fListBox.Items.Count - 1;
                    });
                    pushMessage("Поток 1 выполняется");
                    isLock = false;
                }
                else
                {
                    pushMessage("Поток 1 ожидает ресурс");
                }
                Thread.Sleep(sleepTimeCreater);
            }
        }
        public void countSym()
        {
            while (true)
            {
                if (isLock == false) 
                {
                    isLock = true;
                    if (readNum < Ls.Count)
                    {
                        string L = Ls[readNum];
                        if (Ls.Count > 0)
                        {
                            int count = Counter.countSym(L);

                            if (count % 2 == 0)
                                sListBox.Invoke((MethodInvoker)delegate { sListBox.Items.Add((readNum+1) + ". "+ "Четное кол-во: " + count); });
                            else
                                sListBox.Invoke((MethodInvoker)delegate { sListBox.Items.Add((readNum+1) + ". "+"Нечетное кол-во: " + count); });

                            sListBox.Invoke((MethodInvoker)delegate { sListBox.TopIndex = sListBox.Items.Count - 1; });
                        }
                        readNum++;
                        pushMessage("Поток 2 выполняется");
                    }
                    else
                    {
                        pushMessage("Поток 2 ожидает ресурс");
                    }
                    isLock = false;
                }
                else
                {
                    pushMessage("Поток 2 ожидает ресурс");
                }

                Thread.Sleep(sleepTimeCounter);
            }
        }

        private void FstartButton_Click(object sender, EventArgs e)
        {
            if (!creater.IsAlive) { 
                creater = new Thread(new ThreadStart(createString));
                pushMessage("Поток 1 запущен");
                creater.Start();
                FstartButton.Enabled = false;
                FpauseButton.Enabled = true;
                ostButton.Enabled = true;
            }
        }

        private void SstartButton_Click(object sender, EventArgs e)
        {
            if (!counter.IsAlive) { 
                counter = new Thread(new ThreadStart(countSym));
                pushMessage("Поток 2 запущен"); 
                counter.Start();
                isLock = false;
                SstartButton.Enabled = false;
                ostButton.Enabled = true;  
                SpauseButton.Enabled = true;
            }
        }
      
        private void ostButton_Click(object sender, EventArgs e)
        {
            if (counter.IsAlive) 
            {
                abortCounter();
                SstartButton.Enabled = true;
                SpauseButton.Enabled = false;
            }

            if(creater.IsAlive)
            {
                abortCreater();
                FstartButton.Enabled = true;
                FpauseButton.Enabled = false;
            }
            ostButton.Enabled = false;
        }

        private void abortCreater()
        {

            if (creater.ThreadState==ThreadState.Suspended) creater.Resume();
            creater.Abort();
            pushMessage("Поток 1 завершен");
            
        }

        private void abortCounter()
        {
            if (counter.ThreadState==ThreadState.Suspended) counter.Resume();
            counter.Abort();
            pushMessage("Поток 2 завершен");
        }

     
        private void pushMessage(string message)
        {
            stateListBox.Invoke((MethodInvoker)delegate
            {
                stateListBox.Items.Add(message);
                stateListBox.TopIndex = stateListBox.Items.Count - 1;
            });
        }

   
        private void FpauseButton_Click(object sender, EventArgs e)
        {
            if (creater.IsAlive)
            {
                if (creater.ThreadState==ThreadState.Suspended)
                {
                    creater.Resume();
                    ostButton.Enabled = true;
                }
                else  {
                    pushMessage("Поток 1 приостановлен");
                    creater.Suspend();
                }
            }
        }

        private void SpauseButton_Click(object sender, EventArgs e)
        {
            if (counter.IsAlive)
            {
                if (counter.ThreadState==ThreadState.Suspended)
                {
                    counter.Resume();
                }
                else {
                    pushMessage("Поток 2 приостановлен");
                    counter.Suspend();
                }
            }
        }

        private void fTrackBar_Scroll(object sender, EventArgs e)
        {
            sleepTimeCreater = 5500 - (fTrackBar.Value * 500);
        }

        private void sTrackBar_Scroll(object sender, EventArgs e)
        {
            sleepTimeCounter = 5500 - (sTrackBar.Value * 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
