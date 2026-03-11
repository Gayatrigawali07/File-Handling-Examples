//using System;
//using System.Collections.Generic;
//using System.Linq;

//class H_set_interface
//{
//    HashSet<int> fruits;

//    // Create fruit objects
//    void FruitObjects()
//    {
//        fruits = new HashSet<int>();
//        fruits.Add(1);
//        fruits.Add(2);
//        fruits.Add(3);
//        fruits.Add(4);
//        fruits.Add(5);
//    }

//    // Remove fruit "4" safely while iterating
//    void RemoveFruit()
//    {
//        // Iterate over a copy to remove safely
//        foreach (int f in fruits.ToList())
//        {
//            if (f == 4)
//            {
//                fruits.Remove(f);
//            }
//        }
//    }

//    // Display all fruits
//    void DisplayFruits()
//    {
//        foreach (int f in fruits)
//        {
//            Console.WriteLine(f);
//        }
//    }

//    // Main method
//    public static void Main(string[] args)
//    {
//        H_set_interface ob = new H_set_interface();
//        ob.FruitObjects();
//        ob.RemoveFruit();
//        ob.DisplayFruits();
//    }
//}

