namespace Блокировщик
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
            this.fThreadLabel = new System.Windows.Forms.Label();
            this.sThreadLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.sTrackBar = new System.Windows.Forms.TrackBar();
            this.fTrackBar = new System.Windows.Forms.TrackBar();
            this.FstartButton = new System.Windows.Forms.Button();
            this.FpauseButton = new System.Windows.Forms.Button();
            this.SpauseButton = new System.Windows.Forms.Button();
            this.ostButton = new System.Windows.Forms.Button();
            this.SstartButton = new System.Windows.Forms.Button();
            this.fListBox = new System.Windows.Forms.ListBox();
            this.sListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stateListBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // fThreadLabel
            // 
            this.fThreadLabel.AutoSize = true;
            this.fThreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fThreadLabel.Location = new System.Drawing.Point(2, 49);
            this.fThreadLabel.Name = "fThreadLabel";
            this.fThreadLabel.Size = new System.Drawing.Size(86, 25);
            this.fThreadLabel.TabIndex = 0;
            this.fThreadLabel.Text = "Поток 1";
            // 
            // sThreadLabel
            // 
            this.sThreadLabel.AutoSize = true;
            this.sThreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sThreadLabel.Location = new System.Drawing.Point(270, 49);
            this.sThreadLabel.Name = "sThreadLabel";
            this.sThreadLabel.Size = new System.Drawing.Size(86, 25);
            this.sThreadLabel.TabIndex = 1;
            this.sThreadLabel.Text = "Поток 2";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskNameLabel.Location = new System.Drawing.Point(3, 9);
            this.taskNameLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(176, 20);
            this.taskNameLabel.TabIndex = 2;
            this.taskNameLabel.Text = "Блокировка памяти";
            // 
            // sTrackBar
            // 
            this.sTrackBar.Location = new System.Drawing.Point(272, 501);
            this.sTrackBar.Name = "sTrackBar";
            this.sTrackBar.Size = new System.Drawing.Size(182, 56);
            this.sTrackBar.TabIndex = 3;
            this.sTrackBar.Value = 5;
            this.sTrackBar.Scroll += new System.EventHandler(this.sTrackBar_Scroll);
            // 
            // fTrackBar
            // 
            this.fTrackBar.Location = new System.Drawing.Point(40, 501);
            this.fTrackBar.Name = "fTrackBar";
            this.fTrackBar.Size = new System.Drawing.Size(182, 56);
            this.fTrackBar.TabIndex = 4;
            this.fTrackBar.Value = 5;
            this.fTrackBar.Scroll += new System.EventHandler(this.fTrackBar_Scroll);
            // 
            // FstartButton
            // 
            this.FstartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FstartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FstartButton.Location = new System.Drawing.Point(49, 563);
            this.FstartButton.Name = "FstartButton";
            this.FstartButton.Size = new System.Drawing.Size(156, 26);
            this.FstartButton.TabIndex = 5;
            this.FstartButton.Text = "Старт";
            this.FstartButton.UseVisualStyleBackColor = true;
            this.FstartButton.Click += new System.EventHandler(this.FstartButton_Click);
            // 
            // FpauseButton
            // 
            this.FpauseButton.Enabled = false;
            this.FpauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FpauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FpauseButton.Location = new System.Drawing.Point(49, 595);
            this.FpauseButton.Name = "FpauseButton";
            this.FpauseButton.Size = new System.Drawing.Size(156, 29);
            this.FpauseButton.TabIndex = 7;
            this.FpauseButton.Text = "Пауза";
            this.FpauseButton.UseVisualStyleBackColor = true;
            this.FpauseButton.Click += new System.EventHandler(this.FpauseButton_Click);
            // 
            // SpauseButton
            // 
            this.SpauseButton.Enabled = false;
            this.SpauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpauseButton.Location = new System.Drawing.Point(284, 595);
            this.SpauseButton.Name = "SpauseButton";
            this.SpauseButton.Size = new System.Drawing.Size(156, 29);
            this.SpauseButton.TabIndex = 13;
            this.SpauseButton.Text = "Пауза";
            this.SpauseButton.UseVisualStyleBackColor = true;
            this.SpauseButton.Click += new System.EventHandler(this.SpauseButton_Click);
            // 
            // ostButton
            // 
            this.ostButton.Enabled = false;
            this.ostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ostButton.Location = new System.Drawing.Point(157, 649);
            this.ostButton.Name = "ostButton";
            this.ostButton.Size = new System.Drawing.Size(165, 44);
            this.ostButton.TabIndex = 12;
            this.ostButton.Text = "Останов";
            this.ostButton.UseVisualStyleBackColor = true;
            this.ostButton.Click += new System.EventHandler(this.ostButton_Click);
            // 
            // SstartButton
            // 
            this.SstartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SstartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SstartButton.Location = new System.Drawing.Point(284, 561);
            this.SstartButton.Name = "SstartButton";
            this.SstartButton.Size = new System.Drawing.Size(156, 28);
            this.SstartButton.TabIndex = 11;
            this.SstartButton.Text = "Старт";
            this.SstartButton.UseVisualStyleBackColor = true;
            this.SstartButton.Click += new System.EventHandler(this.SstartButton_Click);
            // 
            // fListBox
            // 
            this.fListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fListBox.FormattingEnabled = true;
            this.fListBox.ItemHeight = 22;
            this.fListBox.Location = new System.Drawing.Point(7, 77);
            this.fListBox.Name = "fListBox";
            this.fListBox.Size = new System.Drawing.Size(262, 422);
            this.fListBox.TabIndex = 14;
            // 
            // sListBox
            // 
            this.sListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sListBox.FormattingEnabled = true;
            this.sListBox.ItemHeight = 22;
            this.sListBox.Location = new System.Drawing.Point(275, 77);
            this.sListBox.Name = "sListBox";
            this.sListBox.Size = new System.Drawing.Size(179, 422);
            this.sListBox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stateListBox
            // 
            this.stateListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateListBox.FormattingEnabled = true;
            this.stateListBox.ItemHeight = 22;
            this.stateListBox.Location = new System.Drawing.Point(460, 77);
            this.stateListBox.Name = "stateListBox";
            this.stateListBox.Size = new System.Drawing.Size(174, 620);
            this.stateListBox.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(458, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 25);
            this.label.TabIndex = 18;
            this.label.Text = "Состояния";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 705);
            this.Controls.Add(this.label);
            this.Controls.Add(this.stateListBox);
            this.Controls.Add(this.sListBox);
            this.Controls.Add(this.fListBox);
            this.Controls.Add(this.SpauseButton);
            this.Controls.Add(this.ostButton);
            this.Controls.Add(this.SstartButton);
            this.Controls.Add(this.FpauseButton);
            this.Controls.Add(this.FstartButton);
            this.Controls.Add(this.fTrackBar);
            this.Controls.Add(this.sTrackBar);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.sThreadLabel);
            this.Controls.Add(this.fThreadLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вычислительные потоки ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fThreadLabel;
        private System.Windows.Forms.Label sThreadLabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TrackBar sTrackBar;
        private System.Windows.Forms.TrackBar fTrackBar;
        private System.Windows.Forms.Button FstartButton;
        private System.Windows.Forms.Button FpauseButton;
        private System.Windows.Forms.Button SpauseButton;
        private System.Windows.Forms.Button ostButton;
        private System.Windows.Forms.Button SstartButton;
        private System.Windows.Forms.ListBox fListBox;
        private System.Windows.Forms.ListBox sListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox stateListBox;
        private System.Windows.Forms.Label label;
    }
}

