using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_Budget_Planning_Task_2
{
    class Buying_Property : Expenditures<double>
    {
        public static void Property_Instalment()
        {
            //Capturing the details needed to calculate how much the user has to pay monthly towards 'repaying' the property loan of buying a house
            Console.WriteLine("\nOkay, you have opted to buy a property. \nNow enter the property purchase price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the property's total deposit:");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the property's interest rate (percentage) ");
            double perc_interest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the the number of months to repay the loan (between 240 and 360): ");
            int period = Convert.ToInt32(Console.ReadLine());

            double p = price - deposit;

            double i = (perc_interest / 100);

            double n = period / 12;

            double A = p * (1 + i * n);

            //this variable stored how much the user will be paying towards their Home Loan monthly
            double monthlyPay1 = A / period;

            Console.WriteLine("\nWith a purchase price of R" + price +
                              "\nA total deposit of R" + deposit +
                              "\nAn interest of " + perc_interest + "%" +
                              "\nAnd a" + period + " months to repay the loan...");

            for (int j = 0; j < 1; j++)
            {
                propertyAmount[j] = monthlyPay1;
            }

             //total left after Tax, Expenses & monthly Home Loan repayment have been deducted
            Tot4 = TotAfterTax - (expenses[0] + propertyAmount[0]);

            Console.WriteLine("\n                  Monthly home loan repayment: R"+ propertyAmount[0] +
                              "\n                                        Total: R" + Math.Round(Tot4,2));

            Rental_Accomodation.Car_Option();

        }

    }
}

