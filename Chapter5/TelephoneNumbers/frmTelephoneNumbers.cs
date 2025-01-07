using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumbers
{
    public partial class frmTelephoneNumbers : Form
    {
        public frmTelephoneNumbers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string LetterToNumber(char letter)
        {
            
            if ("ABC".Contains(letter)) return "2";
            if ("DEF".Contains(letter)) return "3";
            if ("GHI".Contains(letter)) return "4";
            if ("JKL".Contains(letter)) return "5";
            if ("MNO".Contains(letter)) return "6";
            if ("PQRS".Contains(letter)) return "7";
            if ("TUV".Contains(letter)) return "8";
            if ("WXYZ".Contains(letter)) return "9";
            return string.Empty;
        }
        private void btnConverttoNumericOnly_Click(object sender, EventArgs e)
        {   
            txtNumericOnly.Text = string.Empty;
            string alphanumeric = txtAlphanumericNumber.Text.ToUpper();

            for (int i = 0; i < alphanumeric.Length; i++)
            {
                char currentChar = alphanumeric[i];

                if (char.IsLetter(currentChar))
                {
                    txtNumericOnly.Text += LetterToNumber(currentChar);
                }
                else
                {
                    txtNumericOnly.Text += currentChar;
                }
            }
            txtAlphanumericNumber.Focus();
        }
    
    }
}
