using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck2A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalucalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //   (Convert.ToDecimal(txtSubtotal.Text)
            //   * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            int Subtotal = Convert.ToInt32(txtSubtotal.Text);
            decimal DiscountPercent = Convert.ToInt32(txtDiscountPercent.Text)* 0.05m;
            decimal discountAmount = DiscountPercent * Subtotal;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");
            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            decimal total = Subtotal - discountAmount;
            txtTotal.Text = total.ToString("0.00");


            //decimal Tax = 6.875m * pretaxTotal / 100;
            //txtBoxTax.Text = Tax.ToString("0.00");
            //txtBoxPretaxtotal.Text = pretaxTotal.ToString("0.00");


        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
