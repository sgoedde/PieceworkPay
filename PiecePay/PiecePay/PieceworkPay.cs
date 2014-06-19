using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Stephanie Goedde
//Programming I
//Piecework Pay
//4-20-11

namespace PiecePay
{
    public partial class frmPieceworkPay : Form
    {

        public frmPieceworkPay()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strPieces, strPay, strName;
            int intPieces;
            decimal decPay;

            try
            {
                strName = txtBxName.Text;
                strPieces = txtBxPieces.Text;
                intPieces = int.Parse(strPieces);

                if(chkBxSenior.Checked)
                {
                    SeniorBusiness aSeniorBusiness=new SeniorBusiness(strName, intPieces);
                    decPay=aSeniorBusiness.Pay;
                }
                else
                {
                    Business aBusiness = new Business(strName, intPieces);
                    decPay = aBusiness.Pay;
                }

                strPay = decPay.ToString("C2");
                txtBxOutput.Text = strPay;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Entry. Try Again.");
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            decimal decAverage;
            int intCount;

            intCount = Business.Count;

            if (intCount == 0)
            {
                MessageBox.Show("No Data Entered.\nEnter Data.");
            }
            else
            {
                
                decAverage = Business.Average;

                frmSummary aSummary = new frmSummary();

                aSummary.Average = decAverage;
                aSummary.TotalPay = Business.TotalPay;
                aSummary.TotalPieces = Business.TotalPieces;
                aSummary.Count = Business.Count;

                aSummary.Show();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxName.Clear();
            txtBxPieces.Clear();
            txtBxOutput.Clear();
            txtBxName.Focus();
            chkBxSenior.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtBxOutput.Font;
            fontDialog1.ShowDialog();
            txtBxOutput.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.ForeColor;
            colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout About = new frmAbout();
            About.Show();
        }

        private void txtBxPieces_TextChanged(object sender, EventArgs e)
        {
            txtBxOutput.Clear();
        }
    }
}
