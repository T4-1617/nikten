namespace Car_Renting_Program
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
            this.btnAvailibleCars = new System.Windows.Forms.Button();
            this.btnOpenAddCar = new System.Windows.Forms.Button();
            this.btnRentedCars = new System.Windows.Forms.Button();
            this.pnlRentCar = new System.Windows.Forms.Panel();
            this.lstAvalibleCars = new System.Windows.Forms.ListBox();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.pnlRentedCars = new System.Windows.Forms.Panel();
            this.lstRentedCars = new System.Windows.Forms.ListBox();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.tbxRegrristerNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.tbxMaker = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.pnlThankYouReturn = new System.Windows.Forms.Panel();
            this.pnlThankYouRented = new System.Windows.Forms.Panel();
            this.lblNumberOfCarsOpen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlRentCar.SuspendLayout();
            this.pnlRentedCars.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlThankYouReturn.SuspendLayout();
            this.pnlThankYouRented.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvailibleCars
            // 
            this.btnAvailibleCars.Location = new System.Drawing.Point(12, 54);
            this.btnAvailibleCars.Name = "btnAvailibleCars";
            this.btnAvailibleCars.Size = new System.Drawing.Size(75, 23);
            this.btnAvailibleCars.TabIndex = 0;
            this.btnAvailibleCars.Text = "Lediga Bilar";
            this.btnAvailibleCars.UseVisualStyleBackColor = true;
            this.btnAvailibleCars.Click += new System.EventHandler(this.btnAvailibleCars_Click);
            // 
            // btnOpenAddCar
            // 
            this.btnOpenAddCar.Location = new System.Drawing.Point(93, 54);
            this.btnOpenAddCar.Name = "btnOpenAddCar";
            this.btnOpenAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAddCar.TabIndex = 1;
            this.btnOpenAddCar.Text = "Lägg till en bil";
            this.btnOpenAddCar.UseVisualStyleBackColor = true;
            this.btnOpenAddCar.Click += new System.EventHandler(this.btnOpenAddCar_Click);
            // 
            // btnRentedCars
            // 
            this.btnRentedCars.Location = new System.Drawing.Point(174, 54);
            this.btnRentedCars.Name = "btnRentedCars";
            this.btnRentedCars.Size = new System.Drawing.Size(75, 23);
            this.btnRentedCars.TabIndex = 2;
            this.btnRentedCars.Text = "Hyrda Bilar";
            this.btnRentedCars.UseVisualStyleBackColor = true;
            this.btnRentedCars.Click += new System.EventHandler(this.btnRentedCars_Click);
            // 
            // pnlRentCar
            // 
            this.pnlRentCar.Controls.Add(this.lstAvalibleCars);
            this.pnlRentCar.Controls.Add(this.btnRentCar);
            this.pnlRentCar.Location = new System.Drawing.Point(13, 93);
            this.pnlRentCar.Name = "pnlRentCar";
            this.pnlRentCar.Size = new System.Drawing.Size(283, 146);
            this.pnlRentCar.TabIndex = 3;
            this.pnlRentCar.Visible = false;
            // 
            // lstAvalibleCars
            // 
            this.lstAvalibleCars.FormattingEnabled = true;
            this.lstAvalibleCars.Location = new System.Drawing.Point(4, 4);
            this.lstAvalibleCars.Name = "lstAvalibleCars";
            this.lstAvalibleCars.Size = new System.Drawing.Size(195, 134);
            this.lstAvalibleCars.TabIndex = 1;
            this.lstAvalibleCars.SelectedIndexChanged += new System.EventHandler(this.lstAvalibleCars_SelectedIndexChanged);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Enabled = false;
            this.btnRentCar.Location = new System.Drawing.Point(205, 115);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(75, 23);
            this.btnRentCar.TabIndex = 0;
            this.btnRentCar.Text = "Hyr bil";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // pnlRentedCars
            // 
            this.pnlRentedCars.Controls.Add(this.lstRentedCars);
            this.pnlRentedCars.Controls.Add(this.btnReturnCar);
            this.pnlRentedCars.Location = new System.Drawing.Point(13, 258);
            this.pnlRentedCars.Name = "pnlRentedCars";
            this.pnlRentedCars.Size = new System.Drawing.Size(283, 146);
            this.pnlRentedCars.TabIndex = 4;
            this.pnlRentedCars.Visible = false;
            // 
            // lstRentedCars
            // 
            this.lstRentedCars.FormattingEnabled = true;
            this.lstRentedCars.Location = new System.Drawing.Point(3, 3);
            this.lstRentedCars.Name = "lstRentedCars";
            this.lstRentedCars.Size = new System.Drawing.Size(196, 134);
            this.lstRentedCars.TabIndex = 1;
            this.lstRentedCars.SelectedIndexChanged += new System.EventHandler(this.lstRentedCars_SelectedIndexChanged);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Enabled = false;
            this.btnReturnCar.Location = new System.Drawing.Point(205, 114);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCar.TabIndex = 0;
            this.btnReturnCar.Text = "Återlämna bil";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.tbxRegrristerNumber);
            this.pnlAddCar.Controls.Add(this.label4);
            this.pnlAddCar.Controls.Add(this.tbxColor);
            this.pnlAddCar.Controls.Add(this.tbxMaker);
            this.pnlAddCar.Controls.Add(this.tbxModel);
            this.pnlAddCar.Controls.Add(this.label3);
            this.pnlAddCar.Controls.Add(this.label2);
            this.pnlAddCar.Controls.Add(this.label1);
            this.pnlAddCar.Controls.Add(this.btnAddCar);
            this.pnlAddCar.Location = new System.Drawing.Point(13, 447);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(313, 144);
            this.pnlAddCar.TabIndex = 5;
            this.pnlAddCar.Visible = false;
            // 
            // tbxRegrristerNumber
            // 
            this.tbxRegrristerNumber.Location = new System.Drawing.Point(120, 99);
            this.tbxRegrristerNumber.Name = "tbxRegrristerNumber";
            this.tbxRegrristerNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxRegrristerNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Regristerings numer:";
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(120, 71);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(100, 20);
            this.tbxColor.TabIndex = 6;
            // 
            // tbxMaker
            // 
            this.tbxMaker.Location = new System.Drawing.Point(120, 44);
            this.tbxMaker.Name = "tbxMaker";
            this.tbxMaker.Size = new System.Drawing.Size(100, 20);
            this.tbxMaker.TabIndex = 5;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(120, 17);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 20);
            this.tbxModel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Färg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skapare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(226, 47);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 40);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Lägg till bil";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // pnlThankYouReturn
            // 
            this.pnlThankYouReturn.Controls.Add(this.label5);
            this.pnlThankYouReturn.Location = new System.Drawing.Point(302, 94);
            this.pnlThankYouReturn.Name = "pnlThankYouReturn";
            this.pnlThankYouReturn.Size = new System.Drawing.Size(200, 100);
            this.pnlThankYouReturn.TabIndex = 6;
            this.pnlThankYouReturn.Visible = false;
            // 
            // pnlThankYouRented
            // 
            this.pnlThankYouRented.Controls.Add(this.label6);
            this.pnlThankYouRented.Location = new System.Drawing.Point(302, 200);
            this.pnlThankYouRented.Name = "pnlThankYouRented";
            this.pnlThankYouRented.Size = new System.Drawing.Size(200, 100);
            this.pnlThankYouRented.TabIndex = 7;
            this.pnlThankYouRented.Visible = false;
            // 
            // lblNumberOfCarsOpen
            // 
            this.lblNumberOfCarsOpen.AutoSize = true;
            this.lblNumberOfCarsOpen.Location = new System.Drawing.Point(20, 19);
            this.lblNumberOfCarsOpen.Name = "lblNumberOfCarsOpen";
            this.lblNumberOfCarsOpen.Size = new System.Drawing.Size(111, 13);
            this.lblNumberOfCarsOpen.TabIndex = 8;
            this.lblNumberOfCarsOpen.Text = "Det finns 3 lediga bilar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tack för att du lämna tillbacka bilen!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tack för att du hyrde en bil!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 635);
            this.Controls.Add(this.lblNumberOfCarsOpen);
            this.Controls.Add(this.pnlThankYouRented);
            this.Controls.Add(this.pnlThankYouReturn);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlRentedCars);
            this.Controls.Add(this.pnlRentCar);
            this.Controls.Add(this.btnRentedCars);
            this.Controls.Add(this.btnOpenAddCar);
            this.Controls.Add(this.btnAvailibleCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlRentCar.ResumeLayout(false);
            this.pnlRentedCars.ResumeLayout(false);
            this.pnlAddCar.ResumeLayout(false);
            this.pnlAddCar.PerformLayout();
            this.pnlThankYouReturn.ResumeLayout(false);
            this.pnlThankYouReturn.PerformLayout();
            this.pnlThankYouRented.ResumeLayout(false);
            this.pnlThankYouRented.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvailibleCars;
        private System.Windows.Forms.Button btnOpenAddCar;
        private System.Windows.Forms.Button btnRentedCars;
        private System.Windows.Forms.Panel pnlRentCar;
        private System.Windows.Forms.ListBox lstAvalibleCars;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Panel pnlRentedCars;
        private System.Windows.Forms.ListBox lstRentedCars;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.TextBox tbxColor;
        private System.Windows.Forms.TextBox tbxMaker;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Panel pnlThankYouReturn;
        private System.Windows.Forms.Panel pnlThankYouRented;
        private System.Windows.Forms.Label lblNumberOfCarsOpen;
        private System.Windows.Forms.TextBox tbxRegrristerNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

