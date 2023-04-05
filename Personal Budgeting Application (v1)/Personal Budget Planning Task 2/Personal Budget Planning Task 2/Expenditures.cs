using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_Budget_Planning_Task_2
{
    abstract class Expenditures<T>
    {
        private static double Salary;
        public static double[] taxDeduction = new double[1];
        private static double totAfterTax;
        protected static Dictionary<string, T> exps;
        public static double[] expenses = new double[1];
        private static int option1;
        private static int option2;
        public static double[] rentalAmount = new double[1];
        private static double tot3;
        public static double[] propertyAmount = new double[1];
        private static double tot4;
        public static double[] carRepayment = new double[1];
        private static double tot5;
        
        public static double Salary1 { get => Salary; set => Salary = value; }
        public static double TotAfterTax { get => totAfterTax; set => totAfterTax = value; }
        public static int Option1 { get => option1; set => option1 = value; }
        public static double Tot3 { get => tot3; set => tot3 = value; }
        public static double Tot4 { get => tot4; set => tot4 = value; }
        public static double Tot5 { get => tot5; set => tot5 = value; }
        public static int Option2 { get => option2; set => option2 = value; }
    }

}
