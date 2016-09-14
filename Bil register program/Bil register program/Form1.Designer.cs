namespace Bil_register_program
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.List_of_cars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CarManafacturer = new System.Windows.Forms.Label();
            this.Gas_type = new System.Windows.Forms.Label();
            this.tbxRegristerNumber = new System.Windows.Forms.TextBox();
            this.tbxCarMark = new System.Windows.Forms.TextBox();
            this.tbxGas_type = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(168, 273);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Editera";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // List_of_cars
            // 
            this.List_of_cars.FormattingEnabled = true;
            this.List_of_cars.Location = new System.Drawing.Point(12, 64);
            this.List_of_cars.Name = "List_of_cars";
            this.List_of_cars.Size = new System.Drawing.Size(150, 238);
            this.List_of_cars.TabIndex = 1;
            this.List_of_cars.SelectedIndexChanged += new System.EventHandler(this.List_of_cars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista på Bilar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxGas_type);
            this.panel1.Controls.Add(this.tbxCarMark);
            this.panel1.Controls.Add(this.tbxRegristerNumber);
            this.panel1.Controls.Add(this.Gas_type);
            this.panel1.Controls.Add(this.CarManafacturer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(168, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(249, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(330, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Regristerings numer:";
            // 
            // CarManafacturer
            // 
            this.CarManafacturer.AutoSize = true;
            this.CarManafacturer.Location = new System.Drawing.Point(7, 46);
            this.CarManafacturer.Name = "CarManafacturer";
            this.CarManafacturer.Size = new System.Drawing.Size(53, 13);
            this.CarManafacturer.TabIndex = 4;
            this.CarManafacturer.Text = "Bil märke:";
            // 
            // Gas_type
            // 
            this.Gas_type.AutoSize = true;
            this.Gas_type.Location = new System.Drawing.Point(7, 74);
            this.Gas_type.Name = "Gas_type";
            this.Gas_type.Size = new System.Drawing.Size(59, 13);
            this.Gas_type.TabIndex = 5;
            this.Gas_type.Text = "Benisn typ:";
            // 
            // tbxRegristerNumber
            // 
            this.tbxRegristerNumber.Location = new System.Drawing.Point(139, 14);
            this.tbxRegristerNumber.Name = "tbxRegristerNumber";
            this.tbxRegristerNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxRegristerNumber.TabIndex = 6;
            // 
            // tbxCarMark
            // 
            this.tbxCarMark.Location = new System.Drawing.Point(139, 43);
            this.tbxCarMark.Name = "tbxCarMark";
            this.tbxCarMark.Size = new System.Drawing.Size(100, 20);
            this.tbxCarMark.TabIndex = 7;
            // 
            // tbxGas_type
            // 
            this.tbxGas_type.Location = new System.Drawing.Point(139, 71);
            this.tbxGas_type.Name = "tbxGas_type";
            this.tbxGas_type.Size = new System.Drawing.Size(100, 20);
            this.tbxGas_type.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 327);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_of_cars);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListBox List_of_cars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxGas_type;
        private System.Windows.Forms.TextBox tbxCarMark;
        private System.Windows.Forms.TextBox tbxRegristerNumber;
        private System.Windows.Forms.Label Gas_type;
        private System.Windows.Forms.Label CarManafacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}

