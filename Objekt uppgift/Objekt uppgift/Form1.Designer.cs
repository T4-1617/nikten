namespace Objekt_uppgift
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
            this.tbxAdd = new System.Windows.Forms.Button();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbxfirstname = new System.Windows.Forms.TextBox();
            this.tbxLastname = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxAdd
            // 
            this.tbxAdd.Location = new System.Drawing.Point(197, 30);
            this.tbxAdd.Name = "tbxAdd";
            this.tbxAdd.Size = new System.Drawing.Size(75, 23);
            this.tbxAdd.TabIndex = 0;
            this.tbxAdd.Text = "lägg till";
            this.tbxAdd.UseVisualStyleBackColor = true;
            this.tbxAdd.Click += new System.EventHandler(this.tbxAdd_Click);
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(14, 20);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(54, 13);
            this.lblFirstname.TabIndex = 1;
            this.lblFirstname.Text = "För namn:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(12, 50);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(58, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Efternamn:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 217);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(84, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Du har 0 kunder";
            // 
            // tbxfirstname
            // 
            this.tbxfirstname.Location = new System.Drawing.Point(76, 17);
            this.tbxfirstname.Name = "tbxfirstname";
            this.tbxfirstname.Size = new System.Drawing.Size(100, 20);
            this.tbxfirstname.TabIndex = 4;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Location = new System.Drawing.Point(76, 47);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(100, 20);
            this.tbxLastname.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxfirstname);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.tbxAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbxAdd;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbxfirstname;
        private System.Windows.Forms.TextBox tbxLastname;
        private System.Windows.Forms.ListBox listBox1;
    }
}

