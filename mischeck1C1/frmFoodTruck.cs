using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mischeck1C1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtBotxtHotDogSubTotal.Text = (
            //    4.0m * Convert.ToDecimal(txtHotDogs.Text)
            //    ).ToString("0.00");
            int HotDogs = Convert.ToInt32(txtHotDogs.Text);
            decimal HotDogsPrice = 5.0m;
            decimal HotdogsSubtotal = HotDogs * HotDogsPrice;
            txtBotxtHotDogSubTotal.Text = HotdogsSubtotal.ToString("0.00");

            // txtHamburgersSubTotal.Text = (
            //   5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //   ).ToString("0.00");

            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal hamburgerSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubTotal.Text = hamburgerSubtotal.ToString("0.00");

            //txtBoxPretaxtotal.Text = (
            //  Convert.ToDecimal(txtBotxtHotDogSubTotal.Text) + Convert.ToDecimal(txtHamburgersSubTotal.Text)
            //  ).ToString("0.00");
            decimal pretaxTotal = HotdogsSubtotal + hamburgerSubtotal;
            txtBoxPretaxtotal.Text = pretaxTotal.ToString("0.00");

            //txtBoxTax.Text = (
            //    0.06875m * Convert.ToDecimal(txtBoxPretaxtotal.Text)
            //    ).ToString("0.00");
            decimal Tax = 6.875m * pretaxTotal/ 100;
            txtBoxTax.Text = Tax.ToString("0.00");

            //txtBoxTotal.Text = (
            //    Convert.ToDecimal(txtBoxPretaxtotal.Text) + Convert.ToDecimal(txtBoxTax.Text)
            //    ).ToString("0.00");
            decimal Total = pretaxTotal + Tax;
            txtBoxTotal.Text = Total.ToString("0.00");

            btnClear.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBotxtHotDogSubTotal.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogs.Text = "0";
            txtHamburgersSubTotal.Text = "0";
            txtBoxPretaxtotal.Text = "0";
            txtBoxTax.Text = "0";
            txtBoxTotal.Text = "0";

            txtHotDogs.Focus();

        }
    }
}
