﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCulculate_Click(object sender, EventArgs e)
        {
            decimal monthly_Investment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            decimal futureValue = 0m;

            int numberOfMonth = numberOfYears * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            for (int i = 0; i < numberOfMonth; i++) { 
                futureValue = (futureValue + monthly_Investment) * (1 + monthlyInterestRate);
            }
            txtFutureValue.Text = futureValue.ToString("C");
            txtMonthlyInvestment.Focus();



        }
    }
}
