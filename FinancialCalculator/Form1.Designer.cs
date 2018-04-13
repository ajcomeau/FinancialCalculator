namespace FinancialCalculator
{
    partial class LoanCalc
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLoan = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.NumericUpDown();
            this.txtDownPmtPct = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDownPmtAmt = new System.Windows.Forms.TextBox();
            this.txtPayOff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalAmt = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.tabCompound = new System.Windows.Forms.TabPage();
            this.txtYears = new System.Windows.Forms.NumericUpDown();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFinalAmt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radQuarterly = new System.Windows.Forms.RadioButton();
            this.radMonthly = new System.Windows.Forms.RadioButton();
            this.radYearly = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMonthlyDep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIntRate = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInitDeposit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epLoanCalc = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownPmtPct)).BeginInit();
            this.tabCompound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntRate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLoanCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLoan);
            this.tabControl1.Controls.Add(this.tabCompound);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 266);
            this.tabControl1.TabIndex = 27;
            // 
            // tabLoan
            // 
            this.tabLoan.Controls.Add(this.label12);
            this.tabLoan.Controls.Add(this.txtInterest);
            this.tabLoan.Controls.Add(this.txtDownPmtPct);
            this.tabLoan.Controls.Add(this.label11);
            this.tabLoan.Controls.Add(this.label10);
            this.tabLoan.Controls.Add(this.txtDownPmtAmt);
            this.tabLoan.Controls.Add(this.txtPayOff);
            this.tabLoan.Controls.Add(this.label9);
            this.tabLoan.Controls.Add(this.txtTotalInterest);
            this.tabLoan.Controls.Add(this.label8);
            this.tabLoan.Controls.Add(this.txtLoanTotal);
            this.tabLoan.Controls.Add(this.label7);
            this.tabLoan.Controls.Add(this.txtPayment);
            this.tabLoan.Controls.Add(this.label6);
            this.tabLoan.Controls.Add(this.label5);
            this.tabLoan.Controls.Add(this.label4);
            this.tabLoan.Controls.Add(this.txtMonths);
            this.tabLoan.Controls.Add(this.label3);
            this.tabLoan.Controls.Add(this.txtPrincipal);
            this.tabLoan.Controls.Add(this.label2);
            this.tabLoan.Controls.Add(this.label1);
            this.tabLoan.Controls.Add(this.txtOriginalAmt);
            this.tabLoan.Controls.Add(this.btnGo);
            this.tabLoan.Location = new System.Drawing.Point(4, 22);
            this.tabLoan.Name = "tabLoan";
            this.tabLoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoan.Size = new System.Drawing.Size(414, 240);
            this.tabLoan.TabIndex = 0;
            this.tabLoan.Text = "Loan Calculator";
            this.tabLoan.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Percent";
            // 
            // txtInterest
            // 
            this.txtInterest.DecimalPlaces = 2;
            this.txtInterest.Location = new System.Drawing.Point(108, 149);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(99, 20);
            this.txtInterest.TabIndex = 32;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInterest.ValueChanged += new System.EventHandler(this.txtInterest_ValueChanged);
            // 
            // txtDownPmtPct
            // 
            this.txtDownPmtPct.DecimalPlaces = 2;
            this.txtDownPmtPct.Location = new System.Drawing.Point(107, 44);
            this.txtDownPmtPct.Name = "txtDownPmtPct";
            this.txtDownPmtPct.Size = new System.Drawing.Size(100, 20);
            this.txtDownPmtPct.TabIndex = 28;
            this.txtDownPmtPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDownPmtPct.ValueChanged += new System.EventHandler(this.txtDownPmtPct_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Dollars";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Percent";
            // 
            // txtDownPmtAmt
            // 
            this.txtDownPmtAmt.Location = new System.Drawing.Point(107, 69);
            this.txtDownPmtAmt.Name = "txtDownPmtAmt";
            this.txtDownPmtAmt.Size = new System.Drawing.Size(100, 20);
            this.txtDownPmtAmt.TabIndex = 30;
            this.txtDownPmtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDownPmtAmt.Validating += new System.ComponentModel.CancelEventHandler(this.txtDownPmtAmt_Validating);
            // 
            // txtPayOff
            // 
            this.txtPayOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPayOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayOff.Location = new System.Drawing.Point(266, 174);
            this.txtPayOff.Name = "txtPayOff";
            this.txtPayOff.ReadOnly = true;
            this.txtPayOff.Size = new System.Drawing.Size(109, 29);
            this.txtPayOff.TabIndex = 38;
            this.txtPayOff.TabStop = false;
            this.txtPayOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Loan Completion Date";
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalInterest.Location = new System.Drawing.Point(266, 126);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(109, 29);
            this.txtTotalInterest.TabIndex = 37;
            this.txtTotalInterest.TabStop = false;
            this.txtTotalInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Total Interest";
            // 
            // txtLoanTotal
            // 
            this.txtLoanTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLoanTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanTotal.Location = new System.Drawing.Point(266, 78);
            this.txtLoanTotal.Name = "txtLoanTotal";
            this.txtLoanTotal.ReadOnly = true;
            this.txtLoanTotal.Size = new System.Drawing.Size(109, 29);
            this.txtLoanTotal.TabIndex = 35;
            this.txtLoanTotal.TabStop = false;
            this.txtLoanTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Loan Total";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(266, 30);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(109, 29);
            this.txtPayment.TabIndex = 34;
            this.txtPayment.TabStop = false;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Monthly Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Number of Months";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(107, 122);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 20);
            this.txtMonths.TabIndex = 31;
            this.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonths.TextChanged += new System.EventHandler(this.txtMonths_TextChanged);
            this.txtMonths.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonths_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Loan Principal";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrincipal.Location = new System.Drawing.Point(107, 96);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ReadOnly = true;
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 40;
            this.txtPrincipal.TabStop = false;
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Down Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Original Amount";
            // 
            // txtOriginalAmt
            // 
            this.txtOriginalAmt.Location = new System.Drawing.Point(107, 17);
            this.txtOriginalAmt.Name = "txtOriginalAmt";
            this.txtOriginalAmt.Size = new System.Drawing.Size(100, 20);
            this.txtOriginalAmt.TabIndex = 27;
            this.txtOriginalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOriginalAmt.TextChanged += new System.EventHandler(this.txtOriginalAmt_TextChanged);
            this.txtOriginalAmt.Validating += new System.ComponentModel.CancelEventHandler(this.txtOriginalAmt_Validating);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(51, 180);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(156, 23);
            this.btnGo.TabIndex = 41;
            this.btnGo.Text = "Update";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tabCompound
            // 
            this.tabCompound.Controls.Add(this.txtYears);
            this.tabCompound.Controls.Add(this.btnCalc);
            this.tabCompound.Controls.Add(this.label17);
            this.tabCompound.Controls.Add(this.txtFinalAmt);
            this.tabCompound.Controls.Add(this.groupBox1);
            this.tabCompound.Controls.Add(this.label16);
            this.tabCompound.Controls.Add(this.label15);
            this.tabCompound.Controls.Add(this.txtMonthlyDep);
            this.tabCompound.Controls.Add(this.label14);
            this.tabCompound.Controls.Add(this.txtIntRate);
            this.tabCompound.Controls.Add(this.label13);
            this.tabCompound.Controls.Add(this.txtInitDeposit);
            this.tabCompound.Location = new System.Drawing.Point(4, 22);
            this.tabCompound.Name = "tabCompound";
            this.tabCompound.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompound.Size = new System.Drawing.Size(414, 240);
            this.tabCompound.TabIndex = 1;
            this.tabCompound.Text = "Compound Interest";
            this.tabCompound.UseVisualStyleBackColor = true;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(104, 108);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 20);
            this.txtYears.TabIndex = 3;
            this.txtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(266, 153);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(47, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "Total";
            // 
            // txtFinalAmt
            // 
            this.txtFinalAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFinalAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalAmt.Location = new System.Drawing.Point(104, 147);
            this.txtFinalAmt.Name = "txtFinalAmt";
            this.txtFinalAmt.Size = new System.Drawing.Size(124, 29);
            this.txtFinalAmt.TabIndex = 9;
            this.txtFinalAmt.TabStop = false;
            this.txtFinalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radQuarterly);
            this.groupBox1.Controls.Add(this.radMonthly);
            this.groupBox1.Controls.Add(this.radYearly);
            this.groupBox1.Location = new System.Drawing.Point(258, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compounded ...";
            // 
            // radQuarterly
            // 
            this.radQuarterly.AutoSize = true;
            this.radQuarterly.Location = new System.Drawing.Point(16, 52);
            this.radQuarterly.Name = "radQuarterly";
            this.radQuarterly.Size = new System.Drawing.Size(67, 17);
            this.radQuarterly.TabIndex = 1;
            this.radQuarterly.Text = "Quarterly";
            this.radQuarterly.UseVisualStyleBackColor = true;
            // 
            // radMonthly
            // 
            this.radMonthly.AutoSize = true;
            this.radMonthly.Checked = true;
            this.radMonthly.Location = new System.Drawing.Point(16, 75);
            this.radMonthly.Name = "radMonthly";
            this.radMonthly.Size = new System.Drawing.Size(62, 17);
            this.radMonthly.TabIndex = 2;
            this.radMonthly.TabStop = true;
            this.radMonthly.Text = "Monthly";
            this.radMonthly.UseVisualStyleBackColor = true;
            // 
            // radYearly
            // 
            this.radYearly.AutoSize = true;
            this.radYearly.Location = new System.Drawing.Point(16, 29);
            this.radYearly.Name = "radYearly";
            this.radYearly.Size = new System.Drawing.Size(54, 17);
            this.radYearly.TabIndex = 0;
            this.radYearly.Text = "Yearly";
            this.radYearly.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Years";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Monthly Deposit";
            // 
            // txtMonthlyDep
            // 
            this.txtMonthlyDep.Location = new System.Drawing.Point(104, 81);
            this.txtMonthlyDep.Name = "txtMonthlyDep";
            this.txtMonthlyDep.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyDep.TabIndex = 2;
            this.txtMonthlyDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonthlyDep.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonthlyDep_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Interest Rate";
            // 
            // txtIntRate
            // 
            this.txtIntRate.Location = new System.Drawing.Point(104, 55);
            this.txtIntRate.Name = "txtIntRate";
            this.txtIntRate.Size = new System.Drawing.Size(100, 20);
            this.txtIntRate.TabIndex = 1;
            this.txtIntRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Initial Deposit";
            // 
            // txtInitDeposit
            // 
            this.txtInitDeposit.Location = new System.Drawing.Point(104, 28);
            this.txtInitDeposit.Name = "txtInitDeposit";
            this.txtInitDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtInitDeposit.TabIndex = 0;
            this.txtInitDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInitDeposit.Validating += new System.ComponentModel.CancelEventHandler(this.txtInitDeposit_Validating);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // epLoanCalc
            // 
            this.epLoanCalc.ContainerControl = this;
            // 
            // LoanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 309);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoanCalc";
            this.Text = "Loan Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabLoan.ResumeLayout(false);
            this.tabLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownPmtPct)).EndInit();
            this.tabCompound.ResumeLayout(false);
            this.tabCompound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYears)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntRate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLoanCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLoan;
        private System.Windows.Forms.TabPage tabCompound;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtInterest;
        private System.Windows.Forms.NumericUpDown txtDownPmtPct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDownPmtAmt;
        private System.Windows.Forms.TextBox txtPayOff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalAmt;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFinalAmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radQuarterly;
        private System.Windows.Forms.RadioButton radMonthly;
        private System.Windows.Forms.RadioButton radYearly;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMonthlyDep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtIntRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInitDeposit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ErrorProvider epLoanCalc;
        private System.Windows.Forms.NumericUpDown txtYears;
    }
}

