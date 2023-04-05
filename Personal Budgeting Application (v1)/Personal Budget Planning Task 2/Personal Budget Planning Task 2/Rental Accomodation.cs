using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personal_Budget_Planning_Task_2
{
    class Rental_Accomodation : Buying_A_Car
    {
        public static void InputDetails()
        {
            Console.WriteLine("                      ****HELLO, LET US HELP YOU BUDGET!!***** ");
            Console.WriteLine("-------------------------------------------------------------------------------------------\n");

            //The user should enter their estimated monthly gross salary
            Console.WriteLine("\nEnter your estimated monthly gross salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            //The user should enter their estimated monthly tax deduction
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\nEnter your estimated monthly tax deduction:" + taxDeduction[i]);
                taxDeduction[i] = Convert.ToDouble(Console.ReadLine());
            }

            TotAfterTax = salary - taxDeduction[0];
            Console.WriteLine("\n                                     Total: R" + Math.Round(TotAfterTax,2));
        }

        //This method is to capture the users monthly expenses
        public static void Expenses()
        {
            Console.WriteLine("\n********************************EXPENSES**********************************");

            Console.WriteLine("\nEnter how much you spend monthly on Groceries:");
            double groceriesExpense = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter how much you spend monthly on Water and Electricity:");
            double waterANDelect = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter how much you spend monthly on Travelling(including fuel):");
            double travellingExpense = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter how much you spend monthly on Cellphone and Telephone:");
            double CellORtellExpense = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter how much you spend monthly on Other expenses (e.g. Entertainment):");
            double otherExpenses = Convert.ToDouble(Console.ReadLine());

            exps = new Dictionary<string, double>();
            exps.Add("Groceries:\t\t\t", groceriesExpense);
            exps.Add("Water & Electricity:\t\t", waterANDelect);
            exps.Add("Travelling:\t\t\t", travellingExpense);
            exps.Add("Cell:\t\t\t\t", CellORtellExpense);
            exps.Add("Other Expenses:\t\t\t", otherExpenses);

            //Put the expenses in descending order based on their values
            foreach (KeyValuePair<string, double> exp in exps.OrderByDescending(e => e.Value))
            {
                Console.WriteLine("{0}\tR{1}", exp.Key, exp.Value);
            }

            //Sum of expenses
            double sum = exps.Values.Sum();
            Console.WriteLine("\n                     Total of expenses: R" + Math.Round(sum,2));

            //expenses array
            for (int i = 0; i < 1; i++)
            {
                expenses[i] = sum;
            }

            //total left after Tax & Expenses have been deducted
            double tot2 = TotAfterTax - expenses[0];
            Console.WriteLine("\n                                 Total: R" + Math.Round(tot2,2));

            Accommodation_Option();
        }

        //if the user decides that they want to rent accommodation, this method executes
        public static void Rental_Accommodation()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("\nOkay, you have opted to rent. " +
                                  "\nNow enter the monthly rental amount you are required to pay : ");
                rentalAmount[i] = Convert.ToDouble(Console.ReadLine());
            }

            Tot3 = TotAfterTax - (expenses[0] + rentalAmount[0]);

            //total left after Tax ,Expenses and Rental costs have been deducted 
            Console.WriteLine("\n                                          Total: R" + Math.Round(Tot3,2));

            Car_Option();
        }

        //This method is to allow the user to choose the accomodation type they want 
        public static void Accommodation_Option()
        {
            Console.WriteLine("\n*****Select the option for the type of accommodation you want:****** \n\n" +
                              "1. Renting \n" +
                              "2. Buying a property \n");

            Option1 = Convert.ToInt32(Console.ReadLine());

            if (Option1 == 1)
            {
                Rental_Accommodation();

            }
            else if (Option1 == 2)
            {
                //If the user's choice of accomodation is 2.Buying a property, the system will call the methods in the Buying Property class
                Buying_Property.Property_Instalment();

            }
        }

        //this method takes in the option of whether the user wants to buy a car or not
        public static void Car_Option()
        {
            Console.WriteLine("\n*****Do you plan on buying a car?******\n" +
                "1. Yes \n" +
                "2. No \n");

            Option2 = Convert.ToInt16(Console.ReadLine());

            if (Option2 == 1)
            {
                Buying_A_Car.Car_Details();
            }
            else if (Option2 == 2)
            {
                if (Option1 == 1)
                {
                    Console.WriteLine("\n         Total of all your monthly expenses :R" + (taxDeduction[0] + expenses[0] + rentalAmount[0]) +
                                      "\n             Total left after all deductions: R" + Tot3);
                }
                if (Option1 == 2)
                {
                    Console.WriteLine("\n           Total of all your monthly expenses: R" + (taxDeduction[0] + expenses[0] + propertyAmount[0]) +
                                      "\n                                Total of rent: R" + Tot4);
                }
                Console.WriteLine("\n********Thank you for using our system, we hope we were able to help you.*********");
            }
        }
    }
}