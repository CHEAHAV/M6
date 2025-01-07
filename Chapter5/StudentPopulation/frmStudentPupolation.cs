using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPopulation
{
    public partial class frmStudentPupolation : Form
    {
        public frmStudentPupolation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            double nStudentToday = Convert.ToDouble(txtNumberofstudenttoday.Text);
            double agr = Convert.ToDouble(txtAnnualgrowthrate.Text);
            decimal nYears = Convert.ToDecimal(txtNumberofyears.Text);
            int years;
            double newStudent = 0;
            double pns = 0;
            for (years = 1; years <= nYears; years++) {
                newStudent = nStudentToday * agr;
                nStudentToday += newStudent;
            }
            pns += nStudentToday;
            lblProjectednumberofstudent.Text = pns.ToString();
        }
    }
}
