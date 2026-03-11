//using System;
//using System.Collections.Generic;
//using System.IO;

//// Expense Class – Class & Object
//class Expense
//{
//    public string Date;
//    public string Category;
//    public double Amount;

//    public Expense(string date, string category, double amount)
//    {
//        Date = date;
//        Category = category;
//        Amount = amount;
//    }

//    public override string ToString()
//    {
//        return Date + ": spent " + Amount + " on " + Category;
//    }
//}

//class Program
//{
//    static List<Expense> expenses = new List<Expense>();
//    static string filePath = "expenses.txt"; // File Handling

//    static void Main()
//    {
//        LoadExpenses(); // Load saved expenses from file

//        while (true) // Loop for menu
//        {
//            Console.WriteLine("\n=== Daily Expense Tracker ===");
//            Console.WriteLine("1. Add Expense");
//            Console.WriteLine("2. View Expenses");
//            Console.WriteLine("3. Update Expense");
//            Console.WriteLine("4. Delete Expense");
//            Console.WriteLine("5. Show Total Spending");
//            Console.WriteLine("6. Exit");
//            Console.Write("Enter choice: ");
//            string choice = Console.ReadLine();

//            // Switch Case for menu selection
//            switch (choice)
//            {
//                case "1":
//                    AddExpense();
//                    break;
//                case "2":
//                    ViewExpenses();
//                    break;
//                case "3":
//                    UpdateExpense();
//                    break;
//                case "4":
//                    DeleteExpense();
//                    break;
//                case "5":
//                    ShowTotal();
//                    break;
//                case "6":
//                    SaveExpenses(); // Save before exit
//                    Console.WriteLine("Exiting program...");
//                    return;
//                default:
//                    Console.WriteLine("Invalid choice! Try again.");
//                    break;
//            }
//        }
//    }

//    // Add Expense – CRUD
//    static void AddExpense()
//    {
//        Console.Write("Enter Date (dd/mm/yyyy): ");
//        string date = Console.ReadLine();

//        Console.Write("Enter Category (Food/Travel/Other): ");
//        string category = Console.ReadLine();

//        Console.Write("Enter Amount: ");
//        double amount = Convert.ToDouble(Console.ReadLine());

//        Expense e = new Expense(date, category, amount);
//        expenses.Add(e);
//        Console.WriteLine("Expense added!");
//    }

//    // View Expenses – CRUD
//    static void ViewExpenses()
//    {
//        Console.WriteLine("\n--- All Expenses ---");
//        if (expenses.Count == 0)
//        {
//            Console.WriteLine("No expenses yet.");
//            return;
//        }

//        for (int i = 0; i < expenses.Count; i++)
//        {
//            Console.WriteLine((i + 1) + ". " + expenses[i]);
//        }
//    }

//    // Update Expense – CRUD
//    static void UpdateExpense()
//    {
//        ViewExpenses();
//        if (expenses.Count == 0) return;

//        Console.Write("Enter the number of the expense to update: ");
//        int index = Convert.ToInt32(Console.ReadLine()) - 1;

//        if (index >= 0 && index < expenses.Count)
//        {
//            Console.Write("Enter new Date: ");
//            expenses[index].Date = Console.ReadLine();
//            Console.Write("Enter new Category: ");
//            expenses[index].Category = Console.ReadLine();
//            Console.Write("Enter new Amount: ");
//            expenses[index].Amount = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Expense updated!");
//        }
//        else
//            Console.WriteLine("Invalid index!");
//    }

//    // Delete Expense – CRUD
//    static void DeleteExpense()
//    {
//        ViewExpenses();
//        if (expenses.Count == 0) return;

//        Console.Write("Enter the number of the expense to delete: ");
//        int index = Convert.ToInt32(Console.ReadLine()) - 1;

//        if (index >= 0 && index < expenses.Count)
//        {
//            expenses.RemoveAt(index);
//            Console.WriteLine("Expense deleted!");
//        }
//        else
//            Console.WriteLine("Invalid index!");
//    }

//    // Show Total Spending
//    static void ShowTotal()
//    {
//        double total = 0;
//        foreach (Expense e in expenses)
//        {
//            total += e.Amount;
//        }
//        Console.WriteLine("Total Spending: " + total);
//    }

//    // File Handling – Save
//    static void SaveExpenses()
//    {
//        using (StreamWriter sw = new StreamWriter(filePath))
//        {
//            foreach (Expense e in expenses)
//            {
//                sw.WriteLine(e.Date + "," + e.Category + "," + e.Amount);
//            }
//        }
//    }

//    // File Handling – Load
//    static void LoadExpenses()
//    {
//        if (File.Exists(filePath))
//        {
//            string[] lines = File.ReadAllLines(filePath);
//            foreach (string line in lines)
//            {
//                string[] parts = line.Split(',');
//                if (parts.Length == 3)
//                {
//                    string date = parts[0];
//                    string category = parts[1];
//                    double amount = Convert.ToDouble(parts[2]);
//                    expenses.Add(new Expense(date, category, amount));
//                }
//            }
//        }
//    }
//}