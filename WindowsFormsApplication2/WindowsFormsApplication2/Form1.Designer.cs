namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.firstTbx = new System.Windows.Forms.TextBox();
            this.secondTbx = new System.Windows.Forms.TextBox();
            this.AwnserList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(39, 121);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "button1";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Location = new System.Drawing.Point(120, 121);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(75, 23);
            this.MinusBtn.TabIndex = 1;
            this.MinusBtn.Text = "button2";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Location = new System.Drawing.Point(203, 121);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(75, 23);
            this.divideBtn.TabIndex = 2;
            this.divideBtn.Text = "button3";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(284, 121);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(75, 23);
            this.multiplyBtn.TabIndex = 3;
            this.multiplyBtn.Text = "button4";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // firstTbx
            // 
            this.firstTbx.Location = new System.Drawing.Point(120, 31);
            this.firstTbx.Name = "firstTbx";
            this.firstTbx.Size = new System.Drawing.Size(100, 20);
            this.firstTbx.TabIndex = 4;
            // 
            // secondTbx
            // 
            this.secondTbx.Location = new System.Drawing.Point(120, 57);
            this.secondTbx.Name = "secondTbx";
            this.secondTbx.Size = new System.Drawing.Size(100, 20);
            this.secondTbx.TabIndex = 5;
            // 
            // AwnserList
            // 
            this.AwnserList.FormattingEnabled = true;
            this.AwnserList.Location = new System.Drawing.Point(84, 185);
            this.AwnserList.Name = "AwnserList";
            this.AwnserList.Size = new System.Drawing.Size(208, 121);
            this.AwnserList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 415);
            this.Controls.Add(this.AwnserList);
            this.Controls.Add(this.secondTbx);
            this.Controls.Add(this.firstTbx);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.TextBox firstTbx;
        private System.Windows.Forms.TextBox secondTbx;
        private System.Windows.Forms.ListBox AwnserList;
    }
}

