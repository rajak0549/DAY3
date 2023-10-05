using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiignment_1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the first number to multiply:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number to multiply:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number to multiply:");
            int num3 = int.Parse(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine($"Expected Output:{num1}*{num2}*{num3}={result}");
            Console.ReadLine();
            Console.WriteLine("Enter first number:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double z = double.Parse(Console.ReadLine());
                double result1=(x+y)*z;
            double result2=(x*y)+(y*z);
            Console.WriteLine($"Result of specified numbers{x},{y},{z},(x+y)*z is{result1} and x*y + y*z is {result2} ");
            Console.WriteLine("Enter a digit:");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
            Console.WriteLine("Enter the amount of celsius:");
            double celsius=Convert.ToDouble(Console.ReadLine());
            
            double kelvin = celsius + 273.15;
            double fahrenhiet = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Kelvin={kelvin}");
            Console.WriteLine($"Fahrenhiet={fahrenhiet}");
            Console.WriteLine("Enter the first integer:");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            if(num1 == num2)
            {
                int triplesum = 3 * sum;
                Console.WriteLine($"The sum of {num1} and {num2}is {triplesum}");
            }
            else
            {
                Console.WriteLine($"The sum of {num1 }and {num2}is {sum}");
            }*/
            Console.WriteLine("Enter the number of  days:");
            int totalDays=int.Parse(Console.ReadLine());
            int years = totalDays / 365;
            int weeks=(totalDays % 365) / 7;
            int days=(totalDays % 365) % 7;
            Console.WriteLine($"Years:{years}");
            Console.WriteLine($"Weeks:{weeks}");
            Console.WriteLine($"Days:{days}");
        }



        }
    }
