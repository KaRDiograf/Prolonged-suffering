namespace ProbaC2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LNewGame = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LRecords = new System.Windows.Forms.Label();
            this.LExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slowTime = new System.Windows.Forms.Timer(this.components);
            this.newAch = new System.Windows.Forms.Label();
            this.ShowAchievments = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(479, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(459, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество очков";
            // 
            // LNewGame
            // 
            this.LNewGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNewGame.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNewGame.Location = new System.Drawing.Point(458, 268);
            this.LNewGame.Name = "LNewGame";
            this.LNewGame.Size = new System.Drawing.Size(168, 33);
            this.LNewGame.TabIndex = 4;
            this.LNewGame.Text = "Новая игра";
            this.LNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LNewGame.Click += new System.EventHandler(this.LNewGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(459, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Следующая фигура";
            // 
            // LRecords
            // 
            this.LRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LRecords.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LRecords.Location = new System.Drawing.Point(458, 417);
            this.LRecords.Name = "LRecords";
            this.LRecords.Size = new System.Drawing.Size(168, 33);
            this.LRecords.TabIndex = 6;
            this.LRecords.Text = "Рекорды";
            this.LRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LRecords.Click += new System.EventHandler(this.LRecords_Click);
            // 
            // LExit
            // 
            this.LExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LExit.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LExit.Location = new System.Drawing.Point(458, 463);
            this.LExit.Name = "LExit";
            this.LExit.Size = new System.Drawing.Size(168, 33);
            this.LExit.TabIndex = 7;
            this.LExit.Text = "Выход";
            this.LExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LExit.Click += new System.EventHandler(this.LExit_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(458, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Управление";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // slowTime
            // 
            this.slowTime.Interval = 5000;
            this.slowTime.Tick += new System.EventHandler(this.slowTime_Tick);
            // 
            // newAch
            // 
            this.newAch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newAch.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAch.Location = new System.Drawing.Point(299, 20);
            this.newAch.Name = "newAch";
            this.newAch.Size = new System.Drawing.Size(138, 65);
            this.newAch.TabIndex = 11;
            this.newAch.Text = "Было открыто новое достижение!";
            this.newAch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newAch.Visible = false;
            this.newAch.Click += new System.EventHandler(this.newAch_Click);
            // 
            // ShowAchievments
            // 
            this.ShowAchievments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowAchievments.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAchievments.Location = new System.Drawing.Point(458, 369);
            this.ShowAchievments.Name = "ShowAchievments";
            this.ShowAchievments.Size = new System.Drawing.Size(168, 33);
            this.ShowAchievments.TabIndex = 12;
            this.ShowAchievments.Text = "Достижения";
            this.ShowAchievments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowAchievments.Click += new System.EventHandler(this.ShowAchievments_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProbaC2.Properties.Resources.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowAchievments);
            this.Controls.Add(this.newAch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LExit);
            this.Controls.Add(this.LRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tetris: change your mind v.0.9";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LNewGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LRecords;
        private System.Windows.Forms.Label LExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer slowTime;
        private System.Windows.Forms.Label newAch;
        private System.Windows.Forms.Label ShowAchievments;
        private System.Windows.Forms.PictureBox pictureBox1;









    }
}

