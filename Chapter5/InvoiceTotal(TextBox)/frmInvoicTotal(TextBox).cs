using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal_TextBox_
{
    public partial class frmInvoicTotal : Form
    {
        public frmInvoicTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercent = .0m;

            if (customerType == "R")
            {
                if (subtotal < 100)
                    discountPercent = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercent = .1m;
                else if (subtotal >= 250)
                    discountPercent = .25m;
            }
            else if (customerType == "C")
            {
                if (subtotal < 250)
                    discountPercent = .2m;
                else if (subtotal >= 250 && subtotal < 500)
                    discountPercent = .25m;
                else
                    discountPercent = .3m;
            }
            else if (customerType == "T") {
                if (subtotal < 500)
                    discountPercent = .4m;
                else
                    discountPercent = .5m;
            }
            else
            {
                discountPercent = .1m;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = "$   " + discountAmount.ToString("F2");
            txtTotal.Text = "$   " + invoiceTotal.ToString("F2");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

