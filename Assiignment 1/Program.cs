using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int firstNumber, secondNumber, temp;
            Console.WriteLine("Input the first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            secondNumber = int.Parse(Console.ReadLine());
            temp = firstNumber;
            firstNumber= secondNumber;
            secondNumber= temp;
            Console.WriteLine("After swapping:");
            Console.WriteLine("first Number:" + firstNumber);
            Console.WriteLine("second Number:" + secondNumber);*/
            Console.WriteLine("Enter the number of  days:");
            int totalDays = int.Parse(Console.ReadLine());
            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;
            Console.WriteLine($"Years:{years}");
            Console.WriteLine($"Weeks:{weeks}");
            Console.WriteLine($"Days:{days}");
        }
    }
}
