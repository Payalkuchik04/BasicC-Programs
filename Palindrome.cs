using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace MyProject.net
{
    internal class Palindrome
    {
        static void Main()
        {
           
            int originalNumber = 131;
            int reversedNumber = 0;
            int tempNumber = originalNumber;

           
            while (tempNumber > 0)
            {
                int remainder = tempNumber % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                tempNumber /= 10;
            }

           
            if (originalNumber == reversedNumber)
            {
                Console.WriteLine($"{originalNumber} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a palindrome.");
            }
        }
    }
}*/


//dry run

//remainder            //reversenumber             //tempnumber
//121 % 1 = 1                (0 * 10) + 1 = 1           121 / 10 = 12
//12 % 1 = 2                  (1 * 10)+2 = 12             12/10 = 1
// 1 % 1 = 1                (12 * 10)+1 = 121               1/10 = 0

//orinalnumber == reversenumber : 121 = 121