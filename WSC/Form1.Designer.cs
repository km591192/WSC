namespace WSC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Answer = new System.Windows.Forms.Label();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter B";
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Location = new System.Drawing.Point(13, 104);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(54, 13);
            this.label_Answer.TabIndex = 2;
            this.label_Answer.Text = "Answer = ";
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(16, 78);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(75, 23);
            this.Calculatebtn.TabIndex = 3;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(91, 10);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(91, 41);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 126);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
    }
}

