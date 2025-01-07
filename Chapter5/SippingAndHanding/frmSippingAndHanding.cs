using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SippingAndHanding
{
    public partial class frmSippingAndHanding : Form
    {
        public frmSippingAndHanding()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateGrandTotal_Click(object sender, EventArgs e)
        {   
            double orderTotal = Convert.ToDouble(txtOrderTotal.Text);
            string customerType = txtCustomerType.Text;
            double shippingCost = 0.0;
            double salesTax = 7;
            double grandTotal;

            if (customerType.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                shippingCost = 0;
            }
            else if (customerType.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                
                if (orderTotal <= 25.00)
                {
                    shippingCost = 5.00;
                }
                else if (orderTotal >=25.01 && orderTotal <= 500.00)
                {
                    shippingCost = 8.00;
                }
                else if (orderTotal >= 500.01 && orderTotal <= 1000.00)
                {
                    shippingCost = 10.00;
                }
                else if (orderTotal >= 1000.01 && orderTotal <= 5000.00)
                {
                    shippingCost = 15.00;
                }
                else
                {
                    shippingCost = 20.00;
                }
            }
            grandTotal = orderTotal + shippingCost + salesTax;
            lblSippingCosts.Text = "$ " + shippingCost.ToString("F2");
            lblSalesTax.Text = "$ " + salesTax.ToString("F2");
            lblGradeTotal.Text = "$ " + grandTotal.ToString("F2");

            txtOrderTotal.Focus();
        }
    }
}

