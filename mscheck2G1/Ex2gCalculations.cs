using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace mscheck2G1
{
   public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            //1a) Switch -with no default
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string IF01(string customerType)
        {
            //1b) Separate 'if' statement
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIF01(string customerType)
            {
                //1c) if elseif
                decimal discountPercent = -1m;
                if (customerType == "R")
                    discountPercent = .1m;
               else if (customerType == "C")
                    discountPercent = .2m;
                return discountPercent.ToString("0.0");
            }
        public static string NestedIF01(string customerType)
        {
            //1d) Nested if-else
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
            }
            return discountPercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customerType)
        {
            //1e) Switch 
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = .0m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string IF02(string customerType)
        {
            //2b) Separate 'if' statement w/default
            decimal discountPercent = 0m;
            if (customerType == "R")
                    discountPercent = .1m;
            if (customerType == "C")
                    discountPercent = .2m;
            if (customerType !="R" && customerType !="C")
                discountPercent = .0m;
         
            return discountPercent.ToString("0.0");
        }
        public static string NestedIF02(string customerType)
        {
            //2d) Nested if-else w/default
            decimal discountPercent = -1m;
            

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .0m;
                }
            }
          
            return discountPercent.ToString("0.0");
        }
        public static string ElseIF02(string customerType)
        {
            //2c) if elseif w/default
            decimal discountPercent = 0m;
            
            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else 
                discountPercent = .0m;
            
            return discountPercent.ToString("0.0");
        }
        //9 to 12
        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = .2m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string If2(string customerType)
        {
            // 2b) Separate 'if' statements
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .2m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType == "T")
                discountPercent = .4m;
            return discountPercent.ToString("0.0");
            
        }
        public static string ElseIf2(string customerType)
        {
            // 2c) if elseif
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .2m;
            if (customerType == "C")
                discountPercent = .2m;
            else if (customerType == "T")
                discountPercent = .4m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse2(string customerType)
        {
            // 2d) Nested if-else
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = .2m;
            }
            if (customerType == "C")
            { 
                discountPercent = .2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountPercent = .4m;
                }
            }
            return discountPercent.ToString("0.0");
        }

    }
}
