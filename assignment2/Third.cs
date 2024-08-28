using System;

class SimpleATM
{
    public void Main2()
    {
        double balance = 1000.00; // Initial balance
        int choice;
        do
        {
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            // Read user choice
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Check balance
                        Console.WriteLine($"Your balance is: Rs. {balance:F2}");
                        break;

                    case 2:
                        // Deposit money
                        Console.Write("Enter amount to deposit: Rs. ");
                        if (double.TryParse(Console.ReadLine(), out double deposit))
                        {
                            if (deposit > 0)
                            {
                                balance += deposit;
                                Console.WriteLine($"Deposited Rs. {deposit:F2}. New balance: Rs. {balance:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Deposit amount must be positive.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;

                    case 3:
                        // Withdraw money
                        Console.Write("Enter amount to withdraw: Rs. ");
                        if (double.TryParse(Console.ReadLine(), out double withdraw))
                        {
                            if (withdraw > 0)
                            {
                                if (withdraw <= balance)
                                {
                                    balance -= withdraw;
                                    Console.WriteLine($"Withdrew Rs. {withdraw:F2}. New balance: Rs. {balance:F2}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Withdrawal amount must be positive.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        } while (choice != 4);
    }
}