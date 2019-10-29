using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            char[] ch = name.ToCharArray();
            string rev;

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = name.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if(b== true)
            {
                Console.WriteLine($"{name} is a Palindrome!");
            }
            else
            {
                Console.WriteLine($"{name} is not a Palindrome.");
            }
        
        }
    }
}
