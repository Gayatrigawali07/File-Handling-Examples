//using System;
//using System.Collections;

//class CharacterCheck
//{
//    public void checkChar()
//    {
//        ArrayList chars = new ArrayList();

//        // Initial characters
//        chars.Add('a');
//        chars.Add('b');
//        chars.Add('z');
//        chars.Add('k');

//        Console.WriteLine("Character List:");
//        foreach (char ch in chars)
//        {
//            Console.WriteLine(ch);
//        }

//        // Check character 'z' without using Contains
//        bool found = false;

//        foreach (char ch in chars)
//        {
//            if (ch == 'z')
//            {
//                found = true;
//                break;
//            }
//        }

//        if (found)
//        {
//            Console.WriteLine("'z' is present in ArrayList");
//        }
//        else
//        {
//            Console.WriteLine("'z' is not present in ArrayList");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        CharacterCheck ob = new CharacterCheck();
//        ob.checkChar();
//    }
//}