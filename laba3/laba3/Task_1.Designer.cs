namespace laba3
{
    partial class Task_1
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
            this.hat = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.knowanswer = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hat
            // 
            this.hat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(156)))), ((int)(((byte)(216)))));
            this.hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.hat.Font = new System.Drawing.Font("Comfortaa", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hat.Location = new System.Drawing.Point(0, 0);
            this.hat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hat.Name = "hat";
            this.hat.Size = new System.Drawing.Size(682, 80);
            this.hat.TabIndex = 0;
            this.hat.Text = "Какова же высота цилиндра?";
            this.hat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // V
            // 
            this.V.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.V.Location = new System.Drawing.Point(245, 150);
            this.V.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(210, 30);
            this.V.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(116, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Объем (V)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(236)))));
            this.label3.Location = new System.Drawing.Point(58, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Площадь (S)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // S
            // 
            this.S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S.Location = new System.Drawing.Point(245, 230);
            this.S.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(210, 30);
            this.S.TabIndex = 3;
            // 
            // knowanswer
            // 
            this.knowanswer.AutoSize = true;
            this.knowanswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(185)))), ((int)(((byte)(209)))));
            this.knowanswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knowanswer.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knowanswer.Location = new System.Drawing.Point(245, 290);
            this.knowanswer.Name = "knowanswer";
            this.knowanswer.Size = new System.Drawing.Size(210, 44);
            this.knowanswer.TabIndex = 5;
            this.knowanswer.Text = "Узнать ответ";
            this.knowanswer.UseVisualStyleBackColor = false;
            this.knowanswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Comfortaa", 20F);
            this.answer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(218)))), ((int)(((byte)(236)))));
            this.answer.Location = new System.Drawing.Point(0, 360);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(682, 114);
            this.answer.TabIndex = 6;
            this.answer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Task_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(77)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(682, 503);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.knowanswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.V);
            this.Controls.Add(this.hat);
            this.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "Task_1";
            this.Text = "Task_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hat;
        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Button knowanswer;
        private System.Windows.Forms.Label answer;
    }
}

