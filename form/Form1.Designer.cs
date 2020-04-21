namespace form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logText = new System.Windows.Forms.TextBox();
            this.pswText = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.butnEnter = new System.Windows.Forms.Button();
            this.attempTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasword";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(90, 2);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(229, 20);
            this.logText.TabIndex = 2;
            this.logText.TextChanged += new System.EventHandler(this.logText_TextChanged);
            // 
            // pswText
            // 
            this.pswText.Location = new System.Drawing.Point(90, 38);
            this.pswText.Name = "pswText";
            this.pswText.Size = new System.Drawing.Size(229, 20);
            this.pswText.TabIndex = 3;
            this.pswText.TextChanged += new System.EventHandler(this.pswText_TextChanged);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(90, 79);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(105, 35);
            this.regBtn.TabIndex = 4;
            this.regBtn.Text = "Registration";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // butnEnter
            // 
            this.butnEnter.Location = new System.Drawing.Point(223, 79);
            this.butnEnter.Name = "butnEnter";
            this.butnEnter.Size = new System.Drawing.Size(96, 35);
            this.butnEnter.TabIndex = 5;
            this.butnEnter.Text = "Enter";
            this.butnEnter.UseVisualStyleBackColor = true;
            this.butnEnter.Click += new System.EventHandler(this.butnEnter_Click);
            // 
            // attempTxt
            // 
            this.attempTxt.AutoSize = true;
            this.attempTxt.Location = new System.Drawing.Point(27, 131);
            this.attempTxt.Name = "attempTxt";
            this.attempTxt.Size = new System.Drawing.Size(0, 13);
            this.attempTxt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 147);
            this.Controls.Add(this.attempTxt);
            this.Controls.Add(this.butnEnter);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.pswText);
            this.Controls.Add(this.logText);
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
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.TextBox pswText;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button butnEnter;
        private System.Windows.Forms.Label attempTxt;
    }
}

