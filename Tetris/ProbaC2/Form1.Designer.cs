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
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
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
            this.LNewGame.Location = new System.Drawing.Point(458, 378);
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
            this.LRecords.Location = new System.Drawing.Point(458, 421);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(652, 542);
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









    }
}

