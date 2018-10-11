using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck2B1._2
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAus = 0m;
            decimal rateAus = 0.717976m;
            decimal usdAus = amountAus * rateAus;

            decimal amountBhutan = 0m;
            decimal rateBhutan = 0.0139831m;
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal AmountCanada =0m;
            decimal RateCanada = 0.759883m;
            decimal usdCanada = AmountCanada * RateCanada;

            decimal AmountJapan = 0m;
            decimal RateJapan = 0.00900094m;
            decimal usdJapan = AmountJapan * RateJapan;

            decimal totalUSD = usdAus + usdBhutan + usdCanada + usdJapan;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            decimal AmountAus = 0m;
            decimal rateAus = 0.7179760m;
            decimal amountBhutan = 0m;
            decimal rateBhutan = 0.0139831m;
            decimal AmountCanada = 0m;
            decimal RateCanada = 0.759883m;
            decimal AmountJapan = 0m;
            decimal RateJapan = 0.00900094m;
        }
    }
}
