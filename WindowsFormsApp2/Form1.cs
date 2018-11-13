using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;

            // 1) if
            result1.Text = Ex2fCalculations.Calc01(textbox1A.Text);

            // 2) if block
            result2.Text = Ex2fCalculations.Calc02(textbox2A.Text);

            // 3) if else
            result3.Text = Ex2fCalculations.Calc03(textbox3A.Text);

            // 4) if else if
            result4.Text = Ex2fCalculations.Calc04(textbox4A.Text);

            // 5) range test
            result5.Text = Ex2fCalculations.Calc05(textbox5A.Text);

            // 6) nested if statements
            result6.Text = Ex2fCalculations.Calc06(textbox6A.Text,textbox6B.Text);

            // 7)
            result7.Text = Ex2fCalculations.Calc07(textbox7A.Text);

            // 8)
            result8.Text = Ex2fCalculations.Calc08(textbox8A.Text, textbox8B.Text);

            // 9)
            result9.Text = Ex2fCalculations.Calc09(textbox9A.Text, textbox9B.Text);

            //10)
            result10.Text = Ex2fCalculations.Calc10(textbox10A.Text, textbox10B.Text);
        }
    }
}
