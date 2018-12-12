using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace mscheck3b1
{
    public class Ex3bCalculations
    {
        //0
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }
        //1
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            

        }
        //2
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;

        }
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            

        }
        //4
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            //(32°F − 32) × 5 / 9 = 0°C------212 to 100
            double celsius = 0.0;
            celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        //5
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            //(0°C × 9 / 5) +32 
           fahrenheit = 0.0;
           fahrenheit = (celsius * 9 / 5) + 32.0;
           //return fahrenheit;
        }
        //6
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal total = hours * rate;
            if (hours > 40) {
                total = total + (hours - 40) * 5;
            }
            return total;
        }
        //7
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;
            while(startIndex < strNumbers.LastIndexOf(' '))
            {
                int endindex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endindex - startIndex);
                decimal number = decimal.Parse(strNumber);
                total += number;
                startIndex = endindex + 1;
            }
            return total;
        }

        internal static decimal TotalHours(decimal strNumbers)
        {
            throw new NotImplementedException();
        }
        //8
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }
    }
}
