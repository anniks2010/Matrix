using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeAndMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userAnswer = Console.ReadLine();
            
            if (IsPalindrome(userAnswer))
            {
                Console.WriteLine($"{userAnswer} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{userAnswer} is not a palindrome.");
            }

            Console.ReadLine();
        }
        public static bool IsPalindrome(string userString)
        {
            int j = userString.Length-1;
            
            //see on natuke pikem lahend
            /*for (int i =0; i< userString.Length; i++)
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }
                j--;
            }*/

            ///See on lühem lahend:

            for(int i = 0; i<=j/2+1; i++, j--) ////komaga eraldamisel on see ikka kolmas element, aga teeb kaks asja. +1 on, kuna 2ga jagamisel ümardam allapoole.
            
            if(userString[i] != userString[j])            
            {
                return false;
            }
            return true;
        }
    }
}
