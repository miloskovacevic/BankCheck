using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCheckApp
{

    public  partial class Form1 : Form
    {
        
        private static double balance = 0;
        private static int totalDeposits = 0;
        private static double totalDepositsAmount = 0;
        private static int totalChecks = 0;
        private static double totalCheckAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            char transaction = ' '; //what transaction are we performing...?

            if (radDeposit.Checked)
            {
                transaction = 'd';
            }
            else if (radCheck.Checked)
            {
                transaction = 'c';
            }
            else if (radServiceCharge.Checked)
            { 
                transaction = 's';
            }

            switch (transaction)
            { 
                case 'd':
                    if (validateTextBox())
                    {
                        double deposit = Convert.ToDouble(txtTransAmount.Text);
                        DepositTransaction(deposit);
                        DisplayBalance();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;

                case 's':
                    if (validateTextBox())
                    {
                        double serviceCharge = Convert.ToDouble(txtTransAmount.Text);
                        ServiceChargeTransaction(serviceCharge);
                        DisplayBalance();

                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;

                case 'c':
                    if (validateTextBox())
                    {
                        double check = Convert.ToDouble(txtTransAmount.Text);
                        checkTransaction(check);
                        DisplayBalance();

                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;

                default:
                    MessageBox.Show("Select type of transaction");
                    break;
            }
            txtTransAmount.Text = string.Empty;
        }

        public void checkTransaction(double c)
        {
            if (balance - c >= 0)
            {
                balance -= c;
                totalChecks++;
                totalCheckAmount += c;
            }
            else
            {
                balance -= 10;
                totalCheckAmount += 10;
                MessageBox.Show("Insufficient funds!");
            }
        }

        private void ServiceChargeTransaction(double s)
        {
            if (balance - s >= 0)
            {
                balance -= s;
            }
            else
            {
                MessageBox.Show("Insufficient funds! Cannot do the transaction!");
            }
           
        }

        private void DepositTransaction(double d)
        {
            balance += d;
            totalDeposits++;
            totalDepositsAmount += d;
        }

        private void ErrorMessage()
        {
            MessageBox.Show("Invalid entry, please enter valid amount!");
        }

        private void DisplayBalance()
        {
            txtBalance.Text = "$" + balance.ToString();
        }

        private bool validateTextBox()
        {
            double value;
            return Double.TryParse(txtTransAmount.Text, out value);
        }

        //clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBalance.Clear();
            txtTransAmount.Clear();
            radCheck.Checked = false;
            radDeposit.Checked = false;
            radServiceCharge.Checked = false;
            balance = 0;
        }

        // button exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //summary button
        private void btnSummary_Click(object sender, EventArgs e)
        {
            string msg = "Total number of deposits: " + totalDeposits.ToString() + "\n\r";
                   msg += "Total amount of deposits: $" + totalDepositsAmount.ToString() + "\n\r";
                   msg += "Total number of checks: " + totalChecks.ToString() + "\n\r";
                   msg += "Total amount of checks: $" + totalCheckAmount.ToString();
                   MessageBox.Show(msg, "Summary");
        }
		void TxtTransAmountKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar.Equals('.')))
			{
				e.Handled=true;
			}
		}

        




    }
}
