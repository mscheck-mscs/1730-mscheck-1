using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck1e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
               (Convert.ToDecimal(txtTest1.Text)+ Convert.ToDecimal(txtTest2.Text)+ Convert.ToDecimal(txtTest3.Text))/3 
                ).ToString("0.00");
        }

        private void buExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtAverage.Text = "0";

        }
    }
}
