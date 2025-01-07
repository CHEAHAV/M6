using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateLeterGrade : Form
    {
        public frmCalculateLeterGrade()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            decimal numericGrade = Convert.ToDecimal(txtNumericGrade.Text);
            string letterGrade;
            if (numericGrade >= 90 && numericGrade <= 100)
            {
                letterGrade = "A";
            }
            else if (numericGrade >= 80 && numericGrade < 90)
            {
                letterGrade = "B";
            }
            else if (numericGrade >= 70 && numericGrade < 80)
            {
                letterGrade = "C";
            }
            else if (numericGrade >= 60 && numericGrade < 70)
            {
                letterGrade = "D";
            }
            else if (numericGrade >= 50 && numericGrade < 60)
            {
                letterGrade = "E";
            }
            else
            {
                letterGrade = "F";
            }
            txtNumericGrade.Text = numericGrade.ToString();
            lblLetterGrade.Text = letterGrade;
            txtNumericGrade.Focus();
        }
    }
}
