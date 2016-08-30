namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.namePlate = new System.Windows.Forms.Label();
            this.förnamnBox = new System.Windows.Forms.TextBox();
            this.efternamBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namePlate
            // 
            this.namePlate.AutoSize = true;
            this.namePlate.Location = new System.Drawing.Point(60, 36);
            this.namePlate.Name = "namePlate";
            this.namePlate.Size = new System.Drawing.Size(112, 13);
            this.namePlate.TabIndex = 1;
            this.namePlate.Text = "Hej, Vad är ditt namn?";
            // 
            // förnamnBox
            // 
            this.förnamnBox.Location = new System.Drawing.Point(63, 76);
            this.förnamnBox.Name = "förnamnBox";
            this.förnamnBox.Size = new System.Drawing.Size(100, 20);
            this.förnamnBox.TabIndex = 2;
            // 
            // efternamBox
            // 
            this.efternamBox.Location = new System.Drawing.Point(169, 76);
            this.efternamBox.Name = "efternamBox";
            this.efternamBox.Size = new System.Drawing.Size(100, 20);
            this.efternamBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 467);
            this.Controls.Add(this.efternamBox);
            this.Controls.Add(this.förnamnBox);
            this.Controls.Add(this.namePlate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label namePlate;
        private System.Windows.Forms.TextBox förnamnBox;
        private System.Windows.Forms.TextBox efternamBox;
    }
}

