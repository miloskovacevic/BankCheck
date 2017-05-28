namespace BankCheckApp
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
        	this.btnCalculate = new System.Windows.Forms.Button();
        	this.btnClear = new System.Windows.Forms.Button();
        	this.btnExit = new System.Windows.Forms.Button();
        	this.btnSummary = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.radServiceCharge = new System.Windows.Forms.RadioButton();
        	this.radCheck = new System.Windows.Forms.RadioButton();
        	this.radDeposit = new System.Windows.Forms.RadioButton();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.txtTransAmount = new System.Windows.Forms.TextBox();
        	this.txtBalance = new System.Windows.Forms.TextBox();
        	this.groupBox1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnCalculate
        	// 
        	this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        	this.btnCalculate.Location = new System.Drawing.Point(26, 207);
        	this.btnCalculate.Name = "btnCalculate";
        	this.btnCalculate.Size = new System.Drawing.Size(75, 23);
        	this.btnCalculate.TabIndex = 0;
        	this.btnCalculate.Text = "Calculate";
        	this.btnCalculate.UseVisualStyleBackColor = true;
        	this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        	// 
        	// btnClear
        	// 
        	this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        	this.btnClear.Location = new System.Drawing.Point(161, 207);
        	this.btnClear.Name = "btnClear";
        	this.btnClear.Size = new System.Drawing.Size(75, 23);
        	this.btnClear.TabIndex = 1;
        	this.btnClear.Text = "Clear";
        	this.btnClear.UseVisualStyleBackColor = true;
        	this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        	// 
        	// btnExit
        	// 
        	this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        	this.btnExit.Location = new System.Drawing.Point(289, 207);
        	this.btnExit.Name = "btnExit";
        	this.btnExit.Size = new System.Drawing.Size(75, 23);
        	this.btnExit.TabIndex = 2;
        	this.btnExit.Text = "Exit";
        	this.btnExit.UseVisualStyleBackColor = true;
        	this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        	// 
        	// btnSummary
        	// 
        	this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        	this.btnSummary.Location = new System.Drawing.Point(412, 207);
        	this.btnSummary.Name = "btnSummary";
        	this.btnSummary.Size = new System.Drawing.Size(75, 23);
        	this.btnSummary.TabIndex = 3;
        	this.btnSummary.Text = "Summary";
        	this.btnSummary.UseVisualStyleBackColor = true;
        	this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.radServiceCharge);
        	this.groupBox1.Controls.Add(this.radCheck);
        	this.groupBox1.Controls.Add(this.radDeposit);
        	this.groupBox1.Location = new System.Drawing.Point(36, 22);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(200, 100);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Options";
        	// 
        	// radServiceCharge
        	// 
        	this.radServiceCharge.AutoSize = true;
        	this.radServiceCharge.Location = new System.Drawing.Point(18, 68);
        	this.radServiceCharge.Name = "radServiceCharge";
        	this.radServiceCharge.Size = new System.Drawing.Size(98, 17);
        	this.radServiceCharge.TabIndex = 2;
        	this.radServiceCharge.TabStop = true;
        	this.radServiceCharge.Text = "Service Charge";
        	this.radServiceCharge.UseVisualStyleBackColor = true;
        	// 
        	// radCheck
        	// 
        	this.radCheck.AutoSize = true;
        	this.radCheck.Location = new System.Drawing.Point(18, 44);
        	this.radCheck.Name = "radCheck";
        	this.radCheck.Size = new System.Drawing.Size(56, 17);
        	this.radCheck.TabIndex = 1;
        	this.radCheck.TabStop = true;
        	this.radCheck.Text = "Check";
        	this.radCheck.UseVisualStyleBackColor = true;
        	// 
        	// radDeposit
        	// 
        	this.radDeposit.AutoSize = true;
        	this.radDeposit.Location = new System.Drawing.Point(18, 20);
        	this.radDeposit.Name = "radDeposit";
        	this.radDeposit.Size = new System.Drawing.Size(61, 17);
        	this.radDeposit.TabIndex = 0;
        	this.radDeposit.TabStop = true;
        	this.radDeposit.Text = "Deposit";
        	this.radDeposit.UseVisualStyleBackColor = true;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(265, 22);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(102, 13);
        	this.label1.TabIndex = 5;
        	this.label1.Text = "Transaction Amount";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(268, 108);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(114, 13);
        	this.label2.TabIndex = 6;
        	this.label2.Text = "New Account Balance";
        	// 
        	// txtTransAmount
        	// 
        	this.txtTransAmount.Location = new System.Drawing.Point(406, 22);
        	this.txtTransAmount.Name = "txtTransAmount";
        	this.txtTransAmount.Size = new System.Drawing.Size(100, 20);
        	this.txtTransAmount.TabIndex = 7;
        	this.txtTransAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTransAmountKeyPress);
        	// 
        	// txtBalance
        	// 
        	this.txtBalance.Location = new System.Drawing.Point(406, 108);
        	this.txtBalance.Name = "txtBalance";
        	this.txtBalance.ReadOnly = true;
        	this.txtBalance.Size = new System.Drawing.Size(100, 20);
        	this.txtBalance.TabIndex = 8;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(525, 260);
        	this.Controls.Add(this.txtBalance);
        	this.Controls.Add(this.txtTransAmount);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.btnSummary);
        	this.Controls.Add(this.btnExit);
        	this.Controls.Add(this.btnClear);
        	this.Controls.Add(this.btnCalculate);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        	this.Name = "Form1";
        	this.Text = "BankCheck";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radServiceCharge;
        private System.Windows.Forms.RadioButton radCheck;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransAmount;
        private System.Windows.Forms.TextBox txtBalance;
    }
}

