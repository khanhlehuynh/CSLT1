using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Session7
    {
        //        1. to calculate the average value of array elements.
        //2. to test if an array contains a specific value.
        //3. to find the index of an array element.
        //4. to remove a specific element from an array.
        //5. to find the maximum and minimum value of an array.
        //6. to reverse an array of integer values.
        //7. to find duplicate values in an array of values.
        //8. to remove duplicate elements from an array.

        static void Bai1(string[] args)
        {
            // to calculate the average value of array elements
            int[] arr = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(arr);
            Console.WriteLine("Average value of array elements: " + average);

        }
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
        // to test if an array contains a specific value
        static void Bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;


            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
            }


            Console.WriteLine($"Mảng ngẫu nhiên: [{string.Join(", ", arr)}]");


            int target = 10;
            bool result = ContainsValue(arr, target);

            Console.WriteLine($"Mảng có chứa số {target} không? -> {result}");
            static bool ContainsValue(int[] arr, int value)
            {
                foreach (int num in arr)
                {
                    if (num == value)
                    {
                        return true;
                    }
                }
                return false;
            }


        }
        // to find the index of an array element.
        static void bai3()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20); 
            }

            Console.WriteLine($"Mảng ngẫu nhiên: [{string.Join(", ", arr)}]");

           
            int target = 10;
            int index = FindIndex(arr, target);

            if (index != -1)
            {
                Console.WriteLine($"Số {target} nằm tại vị trí (index): {index}");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy số {target} trong mảng (Trả về {index})");
            }

          
        }

       
        static int FindIndex(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; 
                }
            }

            return -1;
        }
    }
}
