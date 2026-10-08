using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bai_tap__6
{
    internal class Cau2
    {
        static void Main(string[] args)
        {
            //  Bubble Sort 10 số nguyên

            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Thuật toán Bubble Sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.Write("Mảng sau khi sắp xếp (Bubble Sort): ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            // Linear Search tìm từ trong câu
          
            Console.Write("Nhập vào một câu: ");
            string sentence = Console.ReadLine();

            Console.Write("Nhập từ cần tìm: ");
            string wordToFind = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            bool found = false;
            int foundIndex = -1;

            // Thuật toán Linear Search
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToFind)
                {
                    found = true;
                    foundIndex = i;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Tìm thấy từ '{wordToFind}' tại từ thứ {foundIndex + 1} trong câu.");
            }
            else
            {
                Console.WriteLine($"KHÔNG tìm thấy từ '{wordToFind}' trong câu.");
            }
        }
        }
}
