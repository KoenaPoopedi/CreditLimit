using System;
using System.ComponentModel.Design;

namespace CreditLimit;

class CreditLimit
{
    public static void Main(string[] args)
    {
        //declaring variable for account number.
        int AccountNumber = 1234;
        //initial balance at the start of the month.
        int balance = 5000;
        //Total of all credits applied to the customer (in rands)
        int TotalOfCredit;
        // Total number of items to be taken (how many items)
        int TotalItems;
        //allowed credit limit
        int CreditLimit = balance;
        //price of the item
        int CostOfItems;
        //account charges
        int charges = 50;
        //account deposit varieble
        int depositAmount;

        //declearing the switch option
        int option;
        while (true)
        {
            try
            {
                Console.WriteLine("Please enter your account number:");
                AccountNumber = Convert.ToInt32(Console.ReadLine());

                if (AccountNumber == 1234)
                {
                    Console.WriteLine("########Select Credit Option#######");
                    Console.WriteLine("1. Balance Enquiry\n");
                    Console.WriteLine("2. Take items on credit\n");
                    Console.WriteLine("3. Pay credit amount\n");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("####################################\n\n");
                    Console.WriteLine("Select Option");

                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("\nYour balance is:" + balance);
                                continue;
                            }
                        case 2:
                            {
                                Console.WriteLine("Please enter number of items to be taken:");
                                TotalItems = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Please enter Credit amount for all items:");
                                CostOfItems = Convert.ToInt32(Console.ReadLine());

                                if (CostOfItems % 10 != 0)
                                {   //handles the intiger values, not to be double
                                    Console.WriteLine("\nPlease enter credit amount in multiples of 10");
                                }
                                else if (CostOfItems > balance)
                                {
                                    Console.WriteLine("\n Insufficient balance in your account, Your credit limit is:" + CreditLimit);
                                }
                                else
                                {
                                    TotalOfCredit = balance - charges - CostOfItems;
                                    Console.WriteLine("\nThank you for shopping with us!!!");
                                    Console.WriteLine("\nYour remaining balance is: " + TotalOfCredit);
                                    Console.WriteLine("\nyour number of items is:" + TotalItems +"\nyou are charged :" + charges);
                                }
                                continue;
                            }
                        case 3:
                            {
                                //account payment from the credited
                                Console.WriteLine("Enter amount to Deposit");
                                depositAmount = Convert.ToInt32(Console.ReadLine());
                                //credit payment calculation.
                                balance = depositAmount + balance;
                                Console.WriteLine("Your current balance is:" + balance);
                                continue;

                            }
                        case 4:
                            {
                                //End of program statement.
                                Console.WriteLine("Thank you for shopping with us!!!");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Your option does not exist!!!");
                                continue;
                            }
                    }

                }
                else
                {
                    //error message for pressing a wrong account number.
                    Console.WriteLine("Invalid account number");
                }

            }
            catch (Exception ex)
            {
                //handling an exception of any key that will be wrongly pressed
                Console.WriteLine("Please try to enter a valid entry");
                ex.ToString();
            }
        }
    }
}