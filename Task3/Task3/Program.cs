using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q 1 

            // 	string [ ] ARR= [ 1,7  9  45, ] ERROR
            //String[] ARR = { "1", "7", "9", "45" };

            //	int arr2 = ["Str" "alex","moh" ERROR
            //String[] arr2 = { "Str", "alex", "moh" };

            // string arr3= 'the','fox' 'over' lazy, 'dog',  ] ERROR
            //String[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            // Q 2 
            //  What the index of "Banana","Tomato" ?
            //String[ ]  fruits = ["Tomato", "Banana", "Watermelon"]

            // Tomato Index of 0
            // Banana Index of 1

            //  Q 4

            //Console.Write("Enter three numbers with a comma between them : ");
            //string Num = Console.ReadLine();

            //string[] numbers = Num.Split(',');

            //int num1 = int.Parse(numbers[0].Trim());
            //int num2 = int.Parse(numbers[1].Trim());
            //int num3 = int.Parse(numbers[2].Trim());

            //int sum = num1 + num2 + num3;
            //Console.WriteLine($"The sum of three numbers: {sum}");

            // Q 5 

            //int sum = 0;
            //Console.WriteLine("The Odd Numbers are:");
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " "); 
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("\nThe Sum of odd Numbers is: " + sum);

            // Q 6 

            int rows = 3;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write(new string(' ', rows - i));
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
