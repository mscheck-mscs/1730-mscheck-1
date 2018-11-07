using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscheck2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04TextBox.Text = "";
            result04bTextBox.Text = "";
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            result09bTextBox.Text = "";
            result10TextBox.Text = "";
            result11TextBox.Text = "";
            result12TextBox.Text = "";
            result13TextBox.Text = "";
            //1
            decimal subtotal = Convert.ToDecimal(input01TextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();
            //2
            int timeInService = Convert.ToInt32(input02TextBox.Text);
            //result02TextBox.Text = (timeInService <= 4 || timeInService >=12).ToString();
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();
            //3 - ini
            bool isValid = Convert.ToBoolean(input03TextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);
            //3
            int counter = Convert.ToInt32(input03bTextBox.Text);
            //result03TextBox.Text = (isValid == true && counter++ < years).ToString();
            result03TextBox.Text = (LogicalOperations.q03(isValid, years,counter)).ToString();
            result03bTextBox.Text = counter.ToString();
            //4 
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result04TextBox.Text = (isValid == true & counter++ < years).ToString();
            result04TextBox.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            result04bTextBox.Text = counter.ToString();
            //5
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result05TextBox.Text = (isValid == true || counter++ < years).ToString();
            result05TextBox.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            result05bTextBox.Text = counter.ToString();
            //6
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result06TextBox.Text = (isValid == true | counter++ < years).ToString();
            result06TextBox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            result06bTextBox.Text = counter.ToString();
            //7
            DateTime startDate = Convert.ToDateTime(input07TextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isValid = Convert.ToBoolean(input07dTextBox.Text);
            //result07TextBox.Text = (date > startDate && date < expirationDate || isValid == true).ToString();
            result07TextBox.Text = (LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString();
            //8
            decimal thisYTD = Convert.ToDecimal(input08TextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            //result08TextBox.Text = ((thisYTD > lastYTD || empType == "part time") && startYear < currentYear).ToString();
            result08TextBox.Text = (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)).ToString();
            //9
            counter = Convert.ToInt32(input09TextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            //result09TextBox.Text = (!(counter++ >= years)).ToString();
            result09TextBox.Text = (LogicalOperations.q09(years, counter)).ToString();
            result09bTextBox.Text = counter.ToString();
            //10
            int a = Convert.ToInt32(input10TextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            //result10TextBox.Text = (a + b * c - d).ToString();
            //int x = b * c;
            //int y = a + x;
            //int z = y - d;
            //result10TextBox.Text = z.ToString();
            //result10TextBox.Text = (
            //    a > b && b < c || c < d
            //    ).ToString();
            result10TextBox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();
            //11
            bool member = Convert.ToBoolean(input11TextBox.Text);
            decimal price = Convert.ToDecimal(input11bTextBox.Text);
            float weight = Convert.ToSingle(input11cTextBox.Text);
            result11TextBox.Text = (LogicalOperations.q11(member, price, weight)).ToString();

            //12
            member = Convert.ToBoolean(input12TextBox.Text);
            price = Convert.ToDecimal(input12bTextBox.Text);
            weight = Convert.ToSingle(input12cTextBox.Text);
            result12TextBox.Text = (LogicalOperations.q12(member, price, weight)).ToString();

            //13
            string shipState = input13TextBox.Text;
            string itemType = input13bTextBox.Text;
            result13TextBox.Text = (LogicalOperations.q13(shipState, itemType)).ToString();
        }










        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
