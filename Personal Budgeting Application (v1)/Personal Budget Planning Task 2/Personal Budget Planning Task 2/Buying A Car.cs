using System;
using System.Collections.Generic;
using System.Text;

namespace Personal_Budget_Planning_Task_2
{

    class Buying_A_Car : Expenditures<double>
    {
        //captures all car details and calculates how much the user will be paying monthly towards the car
        public static void Car_Details()
        {
            Console.WriteLine("Enter the car model and make: ");
            string modelmake = Console.ReadLine();

            Console.WriteLine("Enter the purchase price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the total deposit: ");
            double carDeposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the interest rate (%): ");
            double interest = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Enter the estimated insurance premium: ");
            double insurancePremium = Convert.ToDouble(Console.ReadLine());

            int n = 5;

            double p = price - (price * carDeposit);

            double A = p * (1 + (interest * n));

            double periodMonths = n * 12;

            double monthly = A / periodMonths;

            double addInsurance = monthly + insurancePremium;

            for (int a = 0; a < 1; a++)
            {
                carRepayment[a] = addInsurance;

                //if the user's choice of accommodation is 'Renting', this should execute
                if (Option1 == 1)
                {
                    Tot5 = TotAfterTax - (expenses[0] + rentalAmount[0] + carRepayment[0]);

                    Console.WriteLine("\n                   Monthly car loan repayment: R" + carRepayment[0]);
                    Console.WriteLine("\n                                  Monthly tax: R" + (taxDeduction[0] + expenses[0]
                                                                                           + rentalAmount[0] + carRepayment[0]));
                    Console.WriteLine("\n                                        Total: R" + Math.Round(Tot5,2));
                }

                //if the user's choice of accommodation is 'Buying Property', this should execute
                else if (Option1 == 2)
                {
                    Tot5 = TotAfterTax - (expenses[0] + propertyAmount[0] + carRepayment[0]);

                    Console.WriteLine("\n                   Monthly car loan repayment: R" + carRepayment[0]);
                    Console.WriteLine("\n                                  Monthly tax: R" + (taxDeduction[0] + expenses[0] + 
                                                                                             propertyAmount[0] + carRepayment[0]));
                    Console.WriteLine("\n                                Total of rent: R" + Math.Round(Tot5,2));
                }
            }
        } 

        public static void Message()
         {
            double verify = (Salary1 * 75) / 100;

            //if they are renting and not buying a car
            double tot7 = taxDeduction[0] + expenses[0] + rentalAmount[0];
                if (tot7 > verify)
                {
                    if (Option1 == 1)
                    {
                        if (Option2 == 2)
                        {
                            Console.WriteLine("\n             Your monthly expenses exceed 75% of your salary" +
                                      "\n         (Total of all your monthly expenses :R" + (taxDeduction[0] + expenses[0] + rentalAmount[0]) +
                                      "\n             Total left after all deductions: R" + Math.Round(Tot3,2) + ")");
                        }
                    }
                }

            //if they are renting and buying a car
            double tot8 = taxDeduction[0] + expenses[0] + rentalAmount[0] + carRepayment[0];
            if (tot8 > verify) 
            {
                if (Option1 == 1)
                {
                    if (Option2 == 1)
                    {
                       Console.WriteLine("\n             Your monthly expenses exceed 75% of your salary" +
                        "\n         (Total of all your monthly expenses :R" + (taxDeduction[0] + expenses[0] + rentalAmount[0] + carRepayment[0]) +
                        "\n             Total left after all deductions: R" + Math.Round(Tot3,2) + ")");
                    }
                }
            }

            //if they are buying property and not buying a car
            double tot9 = taxDeduction[0] + expenses[0] + propertyAmount[0];
            if (tot9 > verify) 
            {
                if (Option1 == 2)
                {
                    if (Option2 == 2)
                    {
                       Console.WriteLine("\n             Your monthly expenses exceed 75% of your salary" +
                        "\n           (Total of all your monthly expenses: R" + (taxDeduction[0] + expenses[0] + propertyAmount[0]) +
                        "\n                                Total of rent: R" + Math.Round(Tot4,2) + " )");
                    }
                }
            }

            //if they are buying property and buying a car
            double tot10 = taxDeduction[0] + expenses[0] + propertyAmount[0] + carRepayment[0];
            if (tot10 > verify) 
            {
                if (Option1 == 2)
                {
                    if (Option2 == 1)
                    {
                        Console.WriteLine("\n             Your monthly expenses exceed 75% of your salary" +
                        "\n           Total of all your monthly expenses: R" + (taxDeduction[0] + expenses[0] + propertyAmount[0]) +
                        "\n                                Total of rent: R" + Math.Round(Tot4,2) + ")");
                    }
                }
            }
         }

        public static void rating()
        {
            Console.WriteLine("\nRate the application from 1-5 (5 being the highest). \nThank you for using our application, we hope it really helped");
            int rate = Convert.ToInt16(Console.ReadLine());
        }
    }
}

