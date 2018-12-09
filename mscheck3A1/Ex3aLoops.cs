using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mscheck3A1
{
   public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }
        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
             { 
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                 //Loop
                int i = 1;//1
                while (i<= months)//2
                {//5
                futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);//3 Body Calculation
                i++;//4
                }//5
             }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                //do-while Loop
                int i = 1;//1
                do
                {//5
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);//3 Body Calculation
                    i++;//4
                }//5
                while (i <= months);//2 
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        //For-Loop
        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                 
                for (int i = 1; i <= months; i++)//1) 2) 4)
                {//5
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);//3 Body Calculation
                }//5
               
            }
            catch
            {
                return "Invalid input";
            }
            return futureValue.ToString("n2");
        }
        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            //int i = 1, sum = 0;
            //    while (i < 5)
            //    {
            //        sum += i;
            //        i++;
            //    }
            //    return sum.ToString();
            string result = "";
            try
            {
                
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();
                int i = Start;//1
                while (i < End)//2
                {//5
                    result += i;
                    result += " ";
                    i+= Increment;//4
                }//5

            }
            catch
            {
                return "Invalid input";

            }

            return result;
        }
        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();
                int i = Start;
                do
                {
                    result += i;
                   result += " ";
                    i += Increment;


                }
                while (i < End);

            }
            catch
            {
                return "Invalid input";
            }
            return result;

            
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            try
            {
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                int Increment = Int32.Parse(strIncrement);
                if (Increment <= 0) throw new Exception();

                for (int i = Start; i < End; i += Increment)//1) 2) 4)
                {//5
                    result += i;
                    result += " ";
                }//5

            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "0";
            int startIndex = 0;
            int sum = 0;
            try
            {
                int count = Int32.Parse(strCount);
                int i = 0;
                while (i < count){ 
                int endindex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endindex - startIndex);
                int number = Int32.Parse(strNumber);
                    sum += number;
                    startIndex = endindex + 1;
                    i++;
                }
                result = sum.ToString();
            }
            catch
            {
                return "Invalid input";
                
            }

            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;
            
            try
            {
                int Numbers = Int32.Parse(strNumbers);
                int Count = Int32.Parse(strCount);
                int i = 0;
                
                do
                {
                    int endindex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endindex - startIndex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIndex = endindex + 1;
                    i++;
                    result = sum.ToString();

                }
                while (i < Count);
                
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";
            int startIndex = 0;
            int sum = 0;

            try
            {
                int Numbers = Int32.Parse(strNumbers);
                int Count = Int32.Parse(strCount);
               
                if (Count <= 0) throw new Exception();

                for (int i = 0; i < Count; i++)//1) 2) 4)
                {//5
                    int endindex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endindex - startIndex);
                    int number = Int32.Parse(strNumber);
                    startIndex = endindex + 1;
                    i++;
                }//5
                result = sum.ToString();
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

    }
}
