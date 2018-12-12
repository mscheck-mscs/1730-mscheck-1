using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mscheck3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void calcButton_Click(object sender, RoutedEventArgs e)
        {   //0
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextbox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextbox0.Text = discountPercent.ToString("f3");
            }
            catch {
                resultTextbox0.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox0a.Text);
            }
            //1 using output argument
            try
            {
                decimal subtotal = Decimal.Parse(this.inputTextbox1a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextbox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextbox1.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox1a.Text);
            }
            //2 future value
            try
            {
                int months = Int32.Parse(this.inputTextbox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextbox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextbox2c.Text);

                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                
                resultTextbox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextbox2.Text = "";
                MessageBox.Show("Invalid input:\n"
                + this.inputTextbox2a.Text + "\n"
                + this.inputTextbox2b.Text + "\n"
                + this.inputTextbox2c.Text + "\n");
            }
            //3 future value ref argument
            try
            {
                int months = Int32.Parse(this.inputTextbox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(this.inputTextbox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(this.inputTextbox3c.Text);

                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);

                resultTextbox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextbox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                + this.inputTextbox3a.Text + "\n"
                + this.inputTextbox3b.Text + "\n"
                + this.inputTextbox3c.Text + "\n");
            }
            //4 Calcu degrees
            try
            {
                double fahrenhiet = Double.Parse(this.inputTextbox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenhiet);
                resultTextbox4.Text = celsius.ToString("f1");
            }
            catch
            {
                resultTextbox4.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox4a.Text);
            }
            //5 Calcu degrees out
            try
            {
                double celsius = Double.Parse(this.inputTextbox5a.Text);
                double fahrenheit= 0.0;
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resultTextbox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                resultTextbox5.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox5a.Text);
            }
            //6
            try
            {
                decimal hours = decimal.Parse(this.inputTextbox6.Text);
                decimal rate = decimal.Parse(this.inputTextbox6b.Text);
                decimal total = Ex3bCalculations.GrossPay(hours, rate);
                
                resultTextbox6.Text = total.ToString("n2");
            }
            catch
            {
                resultTextbox6.Text = "";
                MessageBox.Show("Invalid input:\n"
                + this.inputTextbox6.Text + "\n"
                + this.inputTextbox6b.Text);
            }
            //7
            try
            {
                //decimal strNumbers = decimal.Parse(this.inputTextbox7.Text);
                this.resultTextbox7.Text =
                    Ex3bCalculations.TotalHours(this.inputTextbox7.Text).ToString("c2");
            }
            catch
            {
                resultTextbox7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox7.Text);
            }
            //8
            try
            {
                
                decimal rate = decimal.Parse(this.inputTextbox8b.Text);
                this.resultTextbox8.Text= 
                    Ex3bCalculations.GrossPay(this.inputTextbox8.Text, rate).ToString("c2");
            }
            catch
            {
                resultTextbox8.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTextbox8.Text + "\n"
                + this.inputTextbox8b.Text);
            }
        }

    }
}
