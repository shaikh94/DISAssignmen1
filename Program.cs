using System;


namespace ConsoleApp1
{
   public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string"); 
            string s = Console.ReadLine(); 
            
            s = s.RemoveVowels(); //call function RemoveVowels
            
            Console.WriteLine(s);
        }

        public static string RemoveVowels(this string s)
        {
            string[] vowels = new string[] { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" }; //create an array of all vowels
            foreach (string c in vowels)
            {
                s = s.Replace(c, ""); //replace all occurences of characters defined in "vowels" apperaing in "s" with empty
            }

            return s;
        }

    }
}
