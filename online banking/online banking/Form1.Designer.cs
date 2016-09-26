namespace online_Banking
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
            this.rbtnCus = new System.Windows.Forms.RadioButton();
            this.rbtnEmp = new System.Windows.Forms.RadioButton();
            this.GrpBoxCusAdd = new System.Windows.Forms.GroupBox();
            this.btnCustAddCust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCusStartCapital = new System.Windows.Forms.TextBox();
            this.tbxCusLName = new System.Windows.Forms.TextBox();
            this.tbxCusFName = new System.Windows.Forms.TextBox();
            this.GrpBoxEmpAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmpAddCust = new System.Windows.Forms.Button();
            this.tbxEmpStartCapital = new System.Windows.Forms.TextBox();
            this.tbxEmpLName = new System.Windows.Forms.TextBox();
            this.tbxEmpFName = new System.Windows.Forms.TextBox();
            this.GrpBoxBrowse = new System.Windows.Forms.GroupBox();
            this.GrpBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.grpBoxDoTransaction = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grpBoxTransactionsLog = new System.Windows.Forms.GroupBox();
            this.lbxTransactionsLog = new System.Windows.Forms.ListBox();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.GroupBoxChoseAccount = new System.Windows.Forms.GroupBox();
            this.lbxAccounts = new System.Windows.Forms.ListBox();
            this.GroupBoxChoseCustomer = new System.Windows.Forms.GroupBox();
            this.lbxCustomers = new System.Windows.Forms.ListBox();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.btnMenuAccBrowse = new System.Windows.Forms.Button();
            this.tbxDoTransactionValue = new System.Windows.Forms.TextBox();
            this.btnDebit = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.GrpBoxCusAdd.SuspendLayout();
            this.GrpBoxEmpAdd.SuspendLayout();
            this.GrpBoxBrowse.SuspendLayout();
            this.GrpBoxAccountDetails.SuspendLayout();
            this.grpBoxDoTransaction.SuspendLayout();
            this.grpBoxTransactionsLog.SuspendLayout();
            this.GroupBoxChoseAccount.SuspendLayout();
            this.GroupBoxChoseCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnCus
            // 
            this.rbtnCus.AutoSize = true;
            this.rbtnCus.Checked = true;
            this.rbtnCus.Location = new System.Drawing.Point(12, 12);
            this.rbtnCus.Name = "rbtnCus";
            this.rbtnCus.Size = new System.Drawing.Size(50, 17);
            this.rbtnCus.TabIndex = 0;
            this.rbtnCus.TabStop = true;
            this.rbtnCus.Text = "Kund";
            this.rbtnCus.UseVisualStyleBackColor = true;
            this.rbtnCus.CheckedChanged += new System.EventHandler(this.rbtnCus_CheckedChanged);
            // 
            // rbtnEmp
            // 
            this.rbtnEmp.AutoSize = true;
            this.rbtnEmp.Location = new System.Drawing.Point(12, 36);
            this.rbtnEmp.Name = "rbtnEmp";
            this.rbtnEmp.Size = new System.Drawing.Size(62, 17);
            this.rbtnEmp.TabIndex = 1;
            this.rbtnEmp.Text = "Anställd";
            this.rbtnEmp.UseVisualStyleBackColor = true;
            this.rbtnEmp.CheckedChanged += new System.EventHandler(this.rbtnEmp_CheckedChanged);
            // 
            // GrpBoxCusAdd
            // 
            this.GrpBoxCusAdd.Controls.Add(this.btnCustAddCust);
            this.GrpBoxCusAdd.Controls.Add(this.label4);
            this.GrpBoxCusAdd.Controls.Add(this.label3);
            this.GrpBoxCusAdd.Controls.Add(this.label2);
            this.GrpBoxCusAdd.Controls.Add(this.tbxCusStartCapital);
            this.GrpBoxCusAdd.Controls.Add(this.tbxCusLName);
            this.GrpBoxCusAdd.Controls.Add(this.tbxCusFName);
            this.GrpBoxCusAdd.Location = new System.Drawing.Point(186, 12);
            this.GrpBoxCusAdd.Name = "GrpBoxCusAdd";
            this.GrpBoxCusAdd.Size = new System.Drawing.Size(254, 168);
            this.GrpBoxCusAdd.TabIndex = 2;
            this.GrpBoxCusAdd.TabStop = false;
            this.GrpBoxCusAdd.Text = "Registrera dig som kund";
            // 
            // btnCustAddCust
            // 
            this.btnCustAddCust.Location = new System.Drawing.Point(119, 108);
            this.btnCustAddCust.Name = "btnCustAddCust";
            this.btnCustAddCust.Size = new System.Drawing.Size(75, 23);
            this.btnCustAddCust.TabIndex = 2;
            this.btnCustAddCust.Text = "Bli kund!";
            this.btnCustAddCust.UseVisualStyleBackColor = true;
            this.btnCustAddCust.Click += new System.EventHandler(this.btnCustAddCust_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Utgångsbeloppet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Efternamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namn";
            // 
            // tbxCusStartCapital
            // 
            this.tbxCusStartCapital.Location = new System.Drawing.Point(9, 110);
            this.tbxCusStartCapital.Name = "tbxCusStartCapital";
            this.tbxCusStartCapital.Size = new System.Drawing.Size(100, 20);
            this.tbxCusStartCapital.TabIndex = 0;
            // 
            // tbxCusLName
            // 
            this.tbxCusLName.Location = new System.Drawing.Point(63, 61);
            this.tbxCusLName.Name = "tbxCusLName";
            this.tbxCusLName.Size = new System.Drawing.Size(100, 20);
            this.tbxCusLName.TabIndex = 0;
            // 
            // tbxCusFName
            // 
            this.tbxCusFName.Location = new System.Drawing.Point(63, 35);
            this.tbxCusFName.Name = "tbxCusFName";
            this.tbxCusFName.Size = new System.Drawing.Size(100, 20);
            this.tbxCusFName.TabIndex = 0;
            // 
            // GrpBoxEmpAdd
            // 
            this.GrpBoxEmpAdd.Controls.Add(this.label1);
            this.GrpBoxEmpAdd.Controls.Add(this.label5);
            this.GrpBoxEmpAdd.Controls.Add(this.label6);
            this.GrpBoxEmpAdd.Controls.Add(this.btnEmpAddCust);
            this.GrpBoxEmpAdd.Controls.Add(this.tbxEmpStartCapital);
            this.GrpBoxEmpAdd.Controls.Add(this.tbxEmpLName);
            this.GrpBoxEmpAdd.Controls.Add(this.tbxEmpFName);
            this.GrpBoxEmpAdd.Location = new System.Drawing.Point(466, 12);
            this.GrpBoxEmpAdd.Name = "GrpBoxEmpAdd";
            this.GrpBoxEmpAdd.Size = new System.Drawing.Size(277, 168);
            this.GrpBoxEmpAdd.TabIndex = 2;
            this.GrpBoxEmpAdd.TabStop = false;
            this.GrpBoxEmpAdd.Text = "Registrera en kund";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utgångsbeloppet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Efternamn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Namn";
            // 
            // btnEmpAddCust
            // 
            this.btnEmpAddCust.Location = new System.Drawing.Point(115, 113);
            this.btnEmpAddCust.Name = "btnEmpAddCust";
            this.btnEmpAddCust.Size = new System.Drawing.Size(111, 22);
            this.btnEmpAddCust.TabIndex = 2;
            this.btnEmpAddCust.Text = "Lägg till en kund";
            this.btnEmpAddCust.UseVisualStyleBackColor = true;
            this.btnEmpAddCust.Click += new System.EventHandler(this.btnEmpAddCust_Click);
            // 
            // tbxEmpStartCapital
            // 
            this.tbxEmpStartCapital.Location = new System.Drawing.Point(9, 114);
            this.tbxEmpStartCapital.Name = "tbxEmpStartCapital";
            this.tbxEmpStartCapital.Size = new System.Drawing.Size(100, 20);
            this.tbxEmpStartCapital.TabIndex = 0;
            // 
            // tbxEmpLName
            // 
            this.tbxEmpLName.Location = new System.Drawing.Point(68, 69);
            this.tbxEmpLName.Name = "tbxEmpLName";
            this.tbxEmpLName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmpLName.TabIndex = 0;
            // 
            // tbxEmpFName
            // 
            this.tbxEmpFName.Location = new System.Drawing.Point(68, 43);
            this.tbxEmpFName.Name = "tbxEmpFName";
            this.tbxEmpFName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmpFName.TabIndex = 0;
            // 
            // GrpBoxBrowse
            // 
            this.GrpBoxBrowse.Controls.Add(this.GrpBoxAccountDetails);
            this.GrpBoxBrowse.Controls.Add(this.GroupBoxChoseAccount);
            this.GrpBoxBrowse.Controls.Add(this.GroupBoxChoseCustomer);
            this.GrpBoxBrowse.Location = new System.Drawing.Point(186, 216);
            this.GrpBoxBrowse.Name = "GrpBoxBrowse";
            this.GrpBoxBrowse.Size = new System.Drawing.Size(730, 414);
            this.GrpBoxBrowse.TabIndex = 2;
            this.GrpBoxBrowse.TabStop = false;
            this.GrpBoxBrowse.Text = "Kunder och konton";
            // 
            // GrpBoxAccountDetails
            // 
            this.GrpBoxAccountDetails.Controls.Add(this.grpBoxDoTransaction);
            this.GrpBoxAccountDetails.Controls.Add(this.lblSaldo);
            this.GrpBoxAccountDetails.Controls.Add(this.grpBoxTransactionsLog);
            this.GrpBoxAccountDetails.Controls.Add(this.tbxMoney);
            this.GrpBoxAccountDetails.Location = new System.Drawing.Point(457, 27);
            this.GrpBoxAccountDetails.Name = "GrpBoxAccountDetails";
            this.GrpBoxAccountDetails.Size = new System.Drawing.Size(248, 378);
            this.GrpBoxAccountDetails.TabIndex = 3;
            this.GrpBoxAccountDetails.TabStop = false;
            this.GrpBoxAccountDetails.Text = "Konto detaljer";
            // 
            // grpBoxDoTransaction
            // 
            this.grpBoxDoTransaction.Controls.Add(this.btnCredit);
            this.grpBoxDoTransaction.Controls.Add(this.btnDebit);
            this.grpBoxDoTransaction.Controls.Add(this.tbxDoTransactionValue);
            this.grpBoxDoTransaction.Location = new System.Drawing.Point(23, 81);
            this.grpBoxDoTransaction.Name = "grpBoxDoTransaction";
            this.grpBoxDoTransaction.Size = new System.Drawing.Size(200, 112);
            this.grpBoxDoTransaction.TabIndex = 3;
            this.grpBoxDoTransaction.TabStop = false;
            this.grpBoxDoTransaction.Text = "In/uttag";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(23, 25);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // grpBoxTransactionsLog
            // 
            this.grpBoxTransactionsLog.Controls.Add(this.lbxTransactionsLog);
            this.grpBoxTransactionsLog.Location = new System.Drawing.Point(26, 199);
            this.grpBoxTransactionsLog.Name = "grpBoxTransactionsLog";
            this.grpBoxTransactionsLog.Size = new System.Drawing.Size(200, 172);
            this.grpBoxTransactionsLog.TabIndex = 0;
            this.grpBoxTransactionsLog.TabStop = false;
            this.grpBoxTransactionsLog.Text = "Transaktionshitoria";
            // 
            // lbxTransactionsLog
            // 
            this.lbxTransactionsLog.FormattingEnabled = true;
            this.lbxTransactionsLog.Location = new System.Drawing.Point(7, 20);
            this.lbxTransactionsLog.Name = "lbxTransactionsLog";
            this.lbxTransactionsLog.Size = new System.Drawing.Size(187, 147);
            this.lbxTransactionsLog.TabIndex = 0;
            // 
            // tbxMoney
            // 
            this.tbxMoney.Location = new System.Drawing.Point(23, 44);
            this.tbxMoney.Name = "tbxMoney";
            this.tbxMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxMoney.TabIndex = 1;
            // 
            // GroupBoxChoseAccount
            // 
            this.GroupBoxChoseAccount.Controls.Add(this.btnAddAcc);
            this.GroupBoxChoseAccount.Controls.Add(this.lbxAccounts);
            this.GroupBoxChoseAccount.Location = new System.Drawing.Point(244, 42);
            this.GroupBoxChoseAccount.Name = "GroupBoxChoseAccount";
            this.GroupBoxChoseAccount.Size = new System.Drawing.Size(200, 363);
            this.GroupBoxChoseAccount.TabIndex = 0;
            this.GroupBoxChoseAccount.TabStop = false;
            this.GroupBoxChoseAccount.Text = "Välj kontot";
            // 
            // lbxAccounts
            // 
            this.lbxAccounts.FormattingEnabled = true;
            this.lbxAccounts.Location = new System.Drawing.Point(7, 19);
            this.lbxAccounts.Name = "lbxAccounts";
            this.lbxAccounts.Size = new System.Drawing.Size(176, 316);
            this.lbxAccounts.TabIndex = 0;
            this.lbxAccounts.SelectedIndexChanged += new System.EventHandler(this.lbxAccounts_SelectedIndexChanged);
            // 
            // GroupBoxChoseCustomer
            // 
            this.GroupBoxChoseCustomer.Controls.Add(this.lbxCustomers);
            this.GroupBoxChoseCustomer.Location = new System.Drawing.Point(22, 42);
            this.GroupBoxChoseCustomer.Name = "GroupBoxChoseCustomer";
            this.GroupBoxChoseCustomer.Size = new System.Drawing.Size(200, 346);
            this.GroupBoxChoseCustomer.TabIndex = 0;
            this.GroupBoxChoseCustomer.TabStop = false;
            this.GroupBoxChoseCustomer.Text = "Välj kunden";
            // 
            // lbxCustomers
            // 
            this.lbxCustomers.FormattingEnabled = true;
            this.lbxCustomers.Location = new System.Drawing.Point(7, 19);
            this.lbxCustomers.Name = "lbxCustomers";
            this.lbxCustomers.Size = new System.Drawing.Size(178, 316);
            this.lbxCustomers.TabIndex = 0;
            this.lbxCustomers.SelectedIndexChanged += new System.EventHandler(this.lbxCustomers_SelectedIndexChanged);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(13, 120);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMenuAdd.TabIndex = 3;
            this.btnMenuAdd.Text = "button1";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            // 
            // btnMenuAccBrowse
            // 
            this.btnMenuAccBrowse.Location = new System.Drawing.Point(12, 150);
            this.btnMenuAccBrowse.Name = "btnMenuAccBrowse";
            this.btnMenuAccBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMenuAccBrowse.TabIndex = 4;
            this.btnMenuAccBrowse.Text = "button2";
            this.btnMenuAccBrowse.UseVisualStyleBackColor = true;
            // 
            // tbxDoTransactionValue
            // 
            this.tbxDoTransactionValue.Location = new System.Drawing.Point(19, 19);
            this.tbxDoTransactionValue.Name = "tbxDoTransactionValue";
            this.tbxDoTransactionValue.Size = new System.Drawing.Size(100, 20);
            this.tbxDoTransactionValue.TabIndex = 0;
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(104, 54);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(75, 23);
            this.btnDebit.TabIndex = 1;
            this.btnDebit.Text = "Ta ut";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(19, 54);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 23);
            this.btnCredit.TabIndex = 3;
            this.btnCredit.Text = "Sätta in";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Location = new System.Drawing.Point(7, 335);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(117, 23);
            this.btnAddAcc.TabIndex = 5;
            this.btnAddAcc.Text = "Skapa ett till konto";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 711);
            this.Controls.Add(this.btnMenuAccBrowse);
            this.Controls.Add(this.btnMenuAdd);
            this.Controls.Add(this.GrpBoxBrowse);
            this.Controls.Add(this.GrpBoxEmpAdd);
            this.Controls.Add(this.GrpBoxCusAdd);
            this.Controls.Add(this.rbtnEmp);
            this.Controls.Add(this.rbtnCus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrpBoxCusAdd.ResumeLayout(false);
            this.GrpBoxCusAdd.PerformLayout();
            this.GrpBoxEmpAdd.ResumeLayout(false);
            this.GrpBoxEmpAdd.PerformLayout();
            this.GrpBoxBrowse.ResumeLayout(false);
            this.GrpBoxAccountDetails.ResumeLayout(false);
            this.GrpBoxAccountDetails.PerformLayout();
            this.grpBoxDoTransaction.ResumeLayout(false);
            this.grpBoxDoTransaction.PerformLayout();
            this.grpBoxTransactionsLog.ResumeLayout(false);
            this.GroupBoxChoseAccount.ResumeLayout(false);
            this.GroupBoxChoseCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnCus;
        private System.Windows.Forms.RadioButton rbtnEmp;
        private System.Windows.Forms.GroupBox GrpBoxCusAdd;
        private System.Windows.Forms.Button btnCustAddCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCusStartCapital;
        private System.Windows.Forms.TextBox tbxCusLName;
        private System.Windows.Forms.TextBox tbxCusFName;
        private System.Windows.Forms.GroupBox GrpBoxEmpAdd;
        private System.Windows.Forms.Button btnEmpAddCust;
        private System.Windows.Forms.TextBox tbxEmpStartCapital;
        private System.Windows.Forms.TextBox tbxEmpLName;
        private System.Windows.Forms.TextBox tbxEmpFName;
        private System.Windows.Forms.GroupBox GrpBoxBrowse;
        private System.Windows.Forms.GroupBox GrpBoxAccountDetails;
        private System.Windows.Forms.GroupBox grpBoxDoTransaction;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox grpBoxTransactionsLog;
        private System.Windows.Forms.ListBox lbxTransactionsLog;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.GroupBox GroupBoxChoseAccount;
        private System.Windows.Forms.ListBox lbxAccounts;
        private System.Windows.Forms.GroupBox GroupBoxChoseCustomer;
        private System.Windows.Forms.ListBox lbxCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.Button btnMenuAccBrowse;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.TextBox tbxDoTransactionValue;
        private System.Windows.Forms.Button btnAddAcc;
    }
}

