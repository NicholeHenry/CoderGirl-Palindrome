using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word");

            string wordChoice = Console.ReadLine();

            bool result = IsPalindrome(wordChoice);

            Console.WriteLine($"{wordChoice}= Palindrome: {result}");
            Console.ReadLine();
        }

        public static bool IsPalindrome(string wordChoice)
        {
            wordChoice = wordChoice.ToLower();
            char[] splitWordChoice = wordChoice.ToCharArray();
            Array.Reverse(splitWordChoice);
            string wordReverse = string.Concat(splitWordChoice);

            if (wordReverse == wordChoice)
            {
                return true;
            }

            else
                return false;

        }


        // TODO: Create a method that recognizes palindromes.
        // The name of the method you create should be IsPalindrome
        // The method should take a string as the input.
        // The method should return a bool - true if the input is a palindrome and false if it is not.
    }
}
