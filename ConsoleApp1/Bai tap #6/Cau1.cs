using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Bai_tap__6
{
    internal class Cau1
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateRandomArray(10, 1, 20);

            Console.WriteLine("Mảng ban đầu:");
            PrintArray(arr);

            // 1. Tính giá trị trung bình
            double avg = CalculateAverage(arr);
            Console.WriteLine($"\n1. Giá trị trung bình: {avg:F2}");

            // 2. Kiểm tra mảng có chứa giá trị cụ thể không
            int searchVal = arr[3];
            bool contains = ContainsValue(arr, searchVal);
            Console.WriteLine($"2. Mảng có chứa {searchVal} không: {contains}");

            // 3. Tìm vị trí (index) của phần tử
            int index = FindIndex(arr, searchVal);
            Console.WriteLine($"3. Vị trí của {searchVal} trong mảng: {index}");

            // 4. Xóa một phần tử cụ thể khỏi mảng
            int[] arrRemoved = RemoveElement(arr, searchVal);
            Console.Write($"4. Mảng sau khi xóa phần tử {searchVal} đầu tiên tìm thấy: ");
            PrintArray(arrRemoved);

            // 5. Tìm giá trị lớn nhất và nhỏ nhất
            FindMaxMin(arr, out int max, out int min);
            Console.WriteLine($"5. Giá trị lớn nhất: {max}, nhỏ nhất: {min}");

            // 6. Đảo ngược mảng
            int[] reversedArr = ReverseArray(arr);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            PrintArray(reversedArr);

            // 7. Tìm các giá trị bị trùng lặp
            List<int> duplicates = FindDuplicates(arr);
            Console.Write("7. Các giá trị bị trùng lặp: ");
            PrintList(duplicates);

            // 8. Xóa các phần tử trùng lặp
            int[] uniqueArr = RemoveDuplicates(arr);
            Console.Write("8. Mảng sau khi xóa trùng lặp: ");
            PrintArray(uniqueArr);

            Console.ReadKey();
        }

        static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(min, max + 1);
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void PrintList(List<int> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Không có");
                return;
            }
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // 1. Tính giá trị trung bình
        static double CalculateAverage(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return (double)sum / arr.Length;
        }

        // 2. Kiểm tra mảng có chứa giá trị cụ thể không
        static bool ContainsValue(int[] arr, int value)
        {
            foreach (int item in arr)
            {
                if (item == value) return true;
            }
            return false;
        }

        // 3. Tìm vị trí (index) của phần tử
        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) return i;
            }
            return -1;
        }

        // 4. Xóa một phần tử cụ thể khỏi mảng (xóa vị trí đầu tiên tìm thấy)
        static int[] RemoveElement(int[] arr, int value)
        {
            int index = FindIndex(arr, value);
            if (index == -1) return arr;

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    newArr[j++] = arr[i];
                }
            }
            return newArr;
        }

        // 5. Tìm giá trị lớn nhất và nhỏ nhất
        static void FindMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }

        // 6. Đảo ngược mảng
        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        // 7. Tìm các giá trị bị trùng lặp
        static List<int> FindDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                    {
                        duplicates.Add(arr[i]);
                    }
                }
            }
            return duplicates;
        }

        // 8. Xóa các phần tử trùng lặp 
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();
            foreach (int item in arr)
            {
                if (!uniqueList.Contains(item))
                {
                    uniqueList.Add(item);
                }
            }
            return uniqueList.ToArray();
        }
    }
}
    

