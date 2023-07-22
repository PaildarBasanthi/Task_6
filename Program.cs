using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Sum of elements: " + sum);
            // average of elements of the array
            double average = sum / arr.Length;
            Console.WriteLine("Average of elements :" + average);
        }
    }
}
