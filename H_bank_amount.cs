//class H_bank_amount
//{
//    static int savedPin = 1234;
//    static double balance = 5000;

//    public static void Main(string[] args)
//    {
//        try
//        {
//            Console.WriteLine("Enter PIN:");
//            int pin = Convert.ToInt32(Console.ReadLine());

//            if (pin != savedPin)
//                throw new Exception("Wrong PIN!");

//            int choice;

//            // Option validation loop
//            while (true)
//            {
//                Console.WriteLine("1. Check Balance");
//                Console.WriteLine("2. Withdraw");
//                Console.WriteLine("Select Option (1 or 2):");

//                choice = Convert.ToInt32(Console.ReadLine());

//                if (choice == 1 || choice == 2)
//                    break;   // valid option
//                else
//                    Console.WriteLine("Please enter only 1 or 2!");
//            }

//            if (choice == 1)
//            {
//                Console.WriteLine("Balance: " + balance);
//            }
//            else
//            {
//                Console.WriteLine("Enter Amount:");
//                double amount = Convert.ToDouble(Console.ReadLine());

//                if (amount > balance)
//                    throw new Exception("Insufficient Balance!");

//                balance -= amount;
//                Console.WriteLine("Withdraw Successful");
//                Console.WriteLine("Remaining Balance: " + balance);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }

//        Console.WriteLine("Thank You!");
//    }
//}