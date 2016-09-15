namespace Costermer_and_emploers
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbxCostemer = new System.Windows.Forms.ListBox();
            this.LbxEmploee = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RbtCostemer = new System.Windows.Forms.RadioButton();
            this.RbnEmployee = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(222, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kunder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Anstälda";
            // 
            // LbxCostemer
            // 
            this.LbxCostemer.FormattingEnabled = true;
            this.LbxCostemer.Location = new System.Drawing.Point(31, 133);
            this.LbxCostemer.Name = "LbxCostemer";
            this.LbxCostemer.Size = new System.Drawing.Size(291, 95);
            this.LbxCostemer.TabIndex = 5;
            // 
            // LbxEmploee
            // 
            this.LbxEmploee.FormattingEnabled = true;
            this.LbxEmploee.Location = new System.Drawing.Point(35, 270);
            this.LbxEmploee.Name = "LbxEmploee";
            this.LbxEmploee.Size = new System.Drawing.Size(291, 95);
            this.LbxEmploee.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RbnEmployee);
            this.panel1.Controls.Add(this.RbtCostemer);
            this.panel1.Location = new System.Drawing.Point(31, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 23);
            this.panel1.TabIndex = 7;
            // 
            // RbtCostemer
            // 
            this.RbtCostemer.AutoSize = true;
            this.RbtCostemer.Location = new System.Drawing.Point(4, 4);
            this.RbtCostemer.Name = "RbtCostemer";
            this.RbtCostemer.Size = new System.Drawing.Size(50, 17);
            this.RbtCostemer.TabIndex = 0;
            this.RbtCostemer.TabStop = true;
            this.RbtCostemer.Text = "Kund";
            this.RbtCostemer.UseVisualStyleBackColor = true;
            // 
            // RbnEmployee
            // 
            this.RbnEmployee.AutoSize = true;
            this.RbnEmployee.Location = new System.Drawing.Point(95, 4);
            this.RbnEmployee.Name = "RbnEmployee";
            this.RbnEmployee.Size = new System.Drawing.Size(60, 17);
            this.RbnEmployee.TabIndex = 1;
            this.RbnEmployee.TabStop = true;
            this.RbnEmployee.Text = "Anstäld";
            this.RbnEmployee.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 377);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbxEmploee);
            this.Controls.Add(this.LbxCostemer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbxCostemer;
        private System.Windows.Forms.ListBox LbxEmploee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RbnEmployee;
        private System.Windows.Forms.RadioButton RbtCostemer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

