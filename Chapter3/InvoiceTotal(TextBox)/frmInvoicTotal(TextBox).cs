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
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);
            decimal discountPercent = 0m;
            if (subtotal > 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }
            else {
                discountPercent = .0m;
            }
            txtSubTotal.Text = "$  " + subtotal.ToString("F2");
            txtDiscountPercent.Text = (discountPercent).ToString("p1");
            decimal discountAmount;
            discountAmount = subtotal * discountPercent;
            txtDiscountAmount.Text = "$  " + discountAmount.ToString("F2");
            decimal total;
            total = subtotal - discountAmount;
            txtTotal.Text =total.ToString("c");
            txtTotal.Focus();
        }
    }
}
