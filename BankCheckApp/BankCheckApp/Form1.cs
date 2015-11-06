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
                    }
                    else
                    {
                        ErrorMessage();
                    }
                    break;
                case 'c':
                    break;
                default:
                    MessageBox.Show("Select type of transaction");
                    break;
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
        }

        // button exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //summary button
        private void btnSummary_Click(object sender, EventArgs e)
        {

        }

        




    }
}
