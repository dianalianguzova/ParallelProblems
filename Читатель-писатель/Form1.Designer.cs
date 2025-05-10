namespace Читатель_писатель
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ostButton = new System.Windows.Forms.Button();
            this.startr1 = new System.Windows.Forms.Button();
            this.pauser1 = new System.Windows.Forms.Button();
            this.pauser2 = new System.Windows.Forms.Button();
            this.startr2 = new System.Windows.Forms.Button();
            this.pauser3 = new System.Windows.Forms.Button();
            this.startr3 = new System.Windows.Forms.Button();
            this.pausew = new System.Windows.Forms.Button();
            this.startw = new System.Windows.Forms.Button();
            this.r1TrackBar = new System.Windows.Forms.TrackBar();
            this.wTrackBar = new System.Windows.Forms.TrackBar();
            this.r3TrackBar = new System.Windows.Forms.TrackBar();
            this.r2TrackBar = new System.Windows.Forms.TrackBar();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.r1Label = new System.Windows.Forms.Label();
            this.r2Label = new System.Windows.Forms.Label();
            this.r3Label = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.r1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ostButton
            // 
            this.ostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ostButton.Location = new System.Drawing.Point(718, 503);
            this.ostButton.Name = "ostButton";
            this.ostButton.Size = new System.Drawing.Size(306, 43);
            this.ostButton.TabIndex = 4;
            this.ostButton.Text = "Останов";
            this.ostButton.UseVisualStyleBackColor = true;
            this.ostButton.Click += new System.EventHandler(this.ostButton_Click);
            // 
            // startr1
            // 
            this.startr1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startr1.Location = new System.Drawing.Point(44, 58);
            this.startr1.Name = "startr1";
            this.startr1.Size = new System.Drawing.Size(75, 23);
            this.startr1.TabIndex = 5;
            this.startr1.Text = "Старт";
            this.startr1.UseVisualStyleBackColor = true;
            this.startr1.Click += new System.EventHandler(this.startr1_Click);
            // 
            // pauser1
            // 
            this.pauser1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauser1.Location = new System.Drawing.Point(44, 87);
            this.pauser1.Name = "pauser1";
            this.pauser1.Size = new System.Drawing.Size(75, 23);
            this.pauser1.TabIndex = 6;
            this.pauser1.Text = "Пауза";
            this.pauser1.UseVisualStyleBackColor = true;
            this.pauser1.Click += new System.EventHandler(this.pauser1_Click);
            // 
            // pauser2
            // 
            this.pauser2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauser2.Location = new System.Drawing.Point(45, 218);
            this.pauser2.Name = "pauser2";
            this.pauser2.Size = new System.Drawing.Size(75, 23);
            this.pauser2.TabIndex = 8;
            this.pauser2.Text = "Пауза";
            this.pauser2.UseVisualStyleBackColor = true;
            this.pauser2.Click += new System.EventHandler(this.pauser2_Click);
            // 
            // startr2
            // 
            this.startr2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startr2.Location = new System.Drawing.Point(45, 189);
            this.startr2.Name = "startr2";
            this.startr2.Size = new System.Drawing.Size(75, 23);
            this.startr2.TabIndex = 7;
            this.startr2.Text = "Старт";
            this.startr2.UseVisualStyleBackColor = true;
            this.startr2.Click += new System.EventHandler(this.startr2_Click);
            // 
            // pauser3
            // 
            this.pauser3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauser3.Location = new System.Drawing.Point(45, 359);
            this.pauser3.Name = "pauser3";
            this.pauser3.Size = new System.Drawing.Size(75, 23);
            this.pauser3.TabIndex = 10;
            this.pauser3.Text = "Пауза";
            this.pauser3.UseVisualStyleBackColor = true;
            this.pauser3.Click += new System.EventHandler(this.pauser3_Click);
            // 
            // startr3
            // 
            this.startr3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startr3.Location = new System.Drawing.Point(45, 330);
            this.startr3.Name = "startr3";
            this.startr3.Size = new System.Drawing.Size(75, 23);
            this.startr3.TabIndex = 9;
            this.startr3.Text = "Старт";
            this.startr3.UseVisualStyleBackColor = true;
            this.startr3.Click += new System.EventHandler(this.startr3_Click);
            // 
            // pausew
            // 
            this.pausew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausew.Location = new System.Drawing.Point(45, 503);
            this.pausew.Name = "pausew";
            this.pausew.Size = new System.Drawing.Size(75, 23);
            this.pausew.TabIndex = 12;
            this.pausew.Text = "Пауза";
            this.pausew.UseVisualStyleBackColor = true;
            this.pausew.Click += new System.EventHandler(this.pausew_Click);
            // 
            // startw
            // 
            this.startw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startw.Location = new System.Drawing.Point(45, 474);
            this.startw.Name = "startw";
            this.startw.Size = new System.Drawing.Size(75, 23);
            this.startw.TabIndex = 11;
            this.startw.Text = "Старт";
            this.startw.UseVisualStyleBackColor = true;
            this.startw.Click += new System.EventHandler(this.startw_Click);
            // 
            // r1TrackBar
            // 
            this.r1TrackBar.Location = new System.Drawing.Point(4, 116);
            this.r1TrackBar.Name = "r1TrackBar";
            this.r1TrackBar.Size = new System.Drawing.Size(157, 56);
            this.r1TrackBar.TabIndex = 13;
            this.r1TrackBar.Value = 5;
            this.r1TrackBar.Scroll += new System.EventHandler(this.r1TrackBar_Scroll);
            // 
            // wTrackBar
            // 
            this.wTrackBar.Location = new System.Drawing.Point(4, 532);
            this.wTrackBar.Name = "wTrackBar";
            this.wTrackBar.Size = new System.Drawing.Size(157, 56);
            this.wTrackBar.TabIndex = 17;
            this.wTrackBar.Value = 5;
            this.wTrackBar.Scroll += new System.EventHandler(this.wTrackBar_Scroll);
            // 
            // r3TrackBar
            // 
            this.r3TrackBar.Location = new System.Drawing.Point(4, 388);
            this.r3TrackBar.Name = "r3TrackBar";
            this.r3TrackBar.Size = new System.Drawing.Size(157, 56);
            this.r3TrackBar.TabIndex = 18;
            this.r3TrackBar.Value = 5;
            this.r3TrackBar.Scroll += new System.EventHandler(this.r3TrackBar_Scroll);
            // 
            // r2TrackBar
            // 
            this.r2TrackBar.Location = new System.Drawing.Point(4, 247);
            this.r2TrackBar.Name = "r2TrackBar";
            this.r2TrackBar.Size = new System.Drawing.Size(157, 56);
            this.r2TrackBar.TabIndex = 19;
            this.r2TrackBar.Value = 5;
            this.r2TrackBar.Scroll += new System.EventHandler(this.r2TrackBar_Scroll);
            // 
            // stateListBox
            // 
            this.stateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.ItemHeight = 22;
            this.stateListBox.Location = new System.Drawing.Point(718, 37);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(306, 444);
            this.stateListBox.TabIndex = 20;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label.Location = new System.Drawing.Point(808, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 25);
            this.label.TabIndex = 21;
            this.label.Text = "Состояния";
            // 
            // labelBD
            // 
            this.labelBD.AutoSize = true;
            this.labelBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBD.Location = new System.Drawing.Point(486, 9);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(128, 25);
            this.labelBD.TabIndex = 22;
            this.labelBD.Text = "База данных";
            // 
            // r1Label
            // 
            this.r1Label.AutoSize = true;
            this.r1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r1Label.Location = new System.Drawing.Point(32, 37);
            this.r1Label.Name = "r1Label";
            this.r1Label.Size = new System.Drawing.Size(100, 18);
            this.r1Label.TabIndex = 23;
            this.r1Label.Text = "Читатель №1";
            // 
            // r2Label
            // 
            this.r2Label.AutoSize = true;
            this.r2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r2Label.Location = new System.Drawing.Point(32, 168);
            this.r2Label.Name = "r2Label";
            this.r2Label.Size = new System.Drawing.Size(100, 18);
            this.r2Label.TabIndex = 24;
            this.r2Label.Text = "Читатель №2";
            // 
            // r3Label
            // 
            this.r3Label.AutoSize = true;
            this.r3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r3Label.Location = new System.Drawing.Point(32, 309);
            this.r3Label.Name = "r3Label";
            this.r3Label.Size = new System.Drawing.Size(100, 18);
            this.r3Label.TabIndex = 25;
            this.r3Label.Text = "Читатель №3";
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wLabel.Location = new System.Drawing.Point(41, 453);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(75, 18);
            this.wLabel.TabIndex = 26;
            this.wLabel.Text = "Писатель";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 584);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.r3Label);
            this.Controls.Add(this.r2Label);
            this.Controls.Add(this.r1Label);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.label);
            this.Controls.Add(this.stateListBox);
            this.Controls.Add(this.r2TrackBar);
            this.Controls.Add(this.r3TrackBar);
            this.Controls.Add(this.wTrackBar);
            this.Controls.Add(this.r1TrackBar);
            this.Controls.Add(this.pausew);
            this.Controls.Add(this.startw);
            this.Controls.Add(this.pauser3);
            this.Controls.Add(this.startr3);
            this.Controls.Add(this.pauser2);
            this.Controls.Add(this.startr2);
            this.Controls.Add(this.pauser1);
            this.Controls.Add(this.startr1);
            this.Controls.Add(this.ostButton);
            this.Name = "Form1";
            this.Text = "Читатель-писатель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.r1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r3TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r2TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ostButton;
        private System.Windows.Forms.Button startr1;
        private System.Windows.Forms.Button pauser1;
        private System.Windows.Forms.Button pauser2;
        private System.Windows.Forms.Button startr2;
        private System.Windows.Forms.Button pauser3;
        private System.Windows.Forms.Button startr3;
        private System.Windows.Forms.Button pausew;
        private System.Windows.Forms.Button startw;
        private System.Windows.Forms.TrackBar r1TrackBar;
        private System.Windows.Forms.TrackBar wTrackBar;
        private System.Windows.Forms.TrackBar r3TrackBar;
        private System.Windows.Forms.TrackBar r2TrackBar;
        private System.Windows.Forms.ListBox stateListBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Label r1Label;
        private System.Windows.Forms.Label r2Label;
        private System.Windows.Forms.Label r3Label;
        private System.Windows.Forms.Label wLabel;
    }
}

