using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck_2F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            // 1) if
            subtotal = Decimal.Parse(textbox1A.Text);
            if (subtotal > 100)
                discountPercent = 0.2m;
            result1.Text = discountPercent.ToString("n2");
            // 2) if block
            subtotal = Decimal.Parse(textbox2A.Text);
            discountPercent = 0m;
            string status = "Standard rate:";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: ";
            }
            result2.Text = status + discountPercent.ToString("n2");
            // 3) if else
        }
    }
}
