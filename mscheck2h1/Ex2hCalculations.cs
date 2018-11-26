using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace mscheck2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear,string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }
        public static string DateCalc08(string strDate)
        {
           string result = "Invalid input";
           DateTime date;
           DateTime.TryParse(strDate, out date);
           result = date.ToShortDateString();
           return result;
            
        }
        ///public static string DateCalc09(String strDateA, String strDateB)
        //{
        //    string result = "Invalid input";
        //    DateTime strDateA;
        //    DateTime strDateB;
        //    DateTime date;
        //    try
        //    {
        //        TimeSpan span = DateTime.strDateA - DateTime.strDateB;
        //        result = date.ToShortDateString();
        //        Console.WriteLine(Span);
        //        Console.WriteLine("{0} days", Span.TotalDays);
        //    }
        //    catch { }
        //    return result;

        //}
        //public static string DateCalc10(String strDateA, String strDateB)
        //{
        //    string result = "Invalid input";

        //    bool pastdue = false;
        //    if (strDateA < strDateB)
        //        pastdue = true;

        //    TimeSpan span = strDateA / strDateB;
        //    Console.WriteLine(Span);
        //    Console.WriteLine("{0} days", Span.TotalDays);


        //    result = date.ToShortDateString();
        //    return result;
        //}
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
           
            s = s.Remove(0);
            s = s.Insert(s.Length, "cr");
           
            
            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
 
            s = s.Remove(1);
            s = s.Insert(s.Length, "rit");

            
            return result;
        }
        public static string StringCalc03(string s)
        {   string result = "Invalid input";
            
            s = s.Remove(0,1);
            s = s.Substring(0,4).ToUpper();
            return result;

        }
        public static string StringCalc04(string s)
        {

            return "";
        }
        public static string StringCalc05(string s)
        {

            return "";
        }
        public static string StringCalc06(string s)
        {

            return "";
        }
        public static string StringCalc07(string s)
        {

            return "";
        }
        public static string StringCalc08(string s)
        {

            return "";
        }
        public static string StringCalc09(string s)
        {

            return "";
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);
            return "";
        }


    }
}