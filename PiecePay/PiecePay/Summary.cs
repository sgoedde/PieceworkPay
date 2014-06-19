using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiecePay
{
    public partial class frmSummary : Form
    {
        public frmSummary()
        {
            InitializeComponent();
        }

        private decimal decTotalPay;
        private decimal decAverage;
        private int intTotalPieces;
        private int intCount;

        public decimal TotalPay
        {
            set
            {
                decTotalPay = value;
            }
        }

        public decimal Average
        {
            set
            {
                decAverage = value;
            }
        }

        public int TotalPieces
        {
            set
            {
                intTotalPieces = value;
            }
        }

        public int Count
        {
            set
            {
                intCount = value;
            }
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            txtBxAveragePay.Text = decAverage.ToString("C2");
            txtBxTotalPay.Text = decTotalPay.ToString("C2");
            txtBxTotalPieces.Text = intTotalPieces.ToString();
            txtBxWorkers.Text = intCount.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
