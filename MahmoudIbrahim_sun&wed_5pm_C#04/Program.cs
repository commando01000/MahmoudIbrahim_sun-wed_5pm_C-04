using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace MahmoudIbrahim_sun_wed_5pm_C_04
{
    internal class Program
    {
        public static (int[] Array1, int[] Array2) ReadArrays(int Arrays_Size)
        {
            int[] Array1 = new int[Arrays_Size];
            int[] Array2 = new int[Arrays_Size];

            Console.WriteLine("Enter the elements of the first array: ");

            for (int i = 0; i < Arrays_Size; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Array1[i] = value;
                }
            }
            Console.WriteLine("Enter the elements of the second array: ");
            for (int i = 0; i < Arrays_Size; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Array2[i] = value;
                }
            }
            return (Array1, Array2);
        }
        public static int[] ReadArray(int Arrays_Size, int[] Arr)
        {
            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < Arrays_Size; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Arr[i] = value;
                }
            }
            return Arr;
        }
        public static int ReadArraySize()
        {
            Console.Write("Enter the size of the array: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }
            else
            {
                return 0;
            }
        }
        public static void SortAndMerge(int[] Array1, int[] Array2)
        {
            Array.Sort(Array1);
            Array.Sort(Array2);

            int[] Sorted = new int[Array1.Length + Array2.Length];

            int i = 0, j = 0, k = 0;

            // Merge the arrays
            while (i < Array1.Length && j < Array2.Length)
            {
                if (Array1[i] < Array2[j])
                {
                    Sorted[k] = Array1[i];
                    i++;
                }
                else
                {
                    Sorted[k] = Array2[j];
                    j++;
                }
                k++;
            }

            // Handle remaining elements in Array1
            while (i < Array1.Length)
            {
                Sorted[k] = Array1[i];

                i++;
                k++;
            }

            // Handle remaining elements in Array2
            while (j < Array2.Length)
            {
                Sorted[k] = Array2[j];
                j++;
                k++;
            }

            Console.WriteLine("Sorted and Merged Array:");
            foreach (int val in Sorted)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
        public static double Calc_Simple_Interest(double p, double r, double t)
        {
            double result = (p * r * t) / 100;
            return result;
        }
        public static double Calc_BMI( double w, double h)
        {
            double result = w / (h * h);
            return result;
        }
        public static string Check_Temperature(double temp)
        {
            // using ternary operator
            string result =  (temp < 10) ? "Just Cold" : (temp > 30) ? "Just hot" : "Just Good";
            return result;
        }
        static void Main(string[] args)
        {
            #region Arrays

            #region Question_1

            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question_2

            //Console.Write("Enter the size of the array: ");
            //if (int.TryParse(Console.ReadLine(), out int size))
            //{
            //    int ArrSize = size;
            //    int total = 0;
            //    for (int i = 0; i < ArrSize; i++)
            //    {
            //        total += i;
            //    }
            //    Console.WriteLine(total);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion

            #region Question_3

            //Console.Write("Enter the size of the arrays: ");
            //int Arrays_Size = ReadArraySize();
            //(int[] Array1, int[] Array2) = ReadArrays(Arrays_Size);
            //SortAndMerge(Array1, Array2);

            #endregion

            #region Question_4

            //Console.Write("Enter the size of the array: ");
            //int Arrays_Size = ReadArraySize();
            //int[] arr1 = new int[Arrays_Size];
            //int count = 0;
            //(arr1) = ReadArray(Arrays_Size, arr1);

            //for (int i = 0; i < Arrays_Size; i++)
            //{
            //    for (int j = i + 1; j < Arrays_Size; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("The number of duplicate elements in the array is: " + count);

            #endregion

            #region Question_5

            //Console.Write("Enter the size of the array: ");
            //int Arrays_Size = ReadArraySize();

            //int max = int.MinValue;
            //int min = int.MaxValue;
            //int[] arr = new int[Arrays_Size];
            //(arr) = ReadArray(Arrays_Size, arr);

            //for (int i = 0; i < Arrays_Size; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine("The maximum element in the array is: " + max);
            //Console.WriteLine("The minimum element in the array is: " + min);

            #endregion

            #region Question_6

            //int Arrays_Size = ReadArraySize();
            //int[] arr1 = new int[Arrays_Size];
            //arr1 = ReadArray(Arrays_Size, arr1);

            //int max = int.MinValue;
            //int secondLargest = int.MinValue;

            //for (int i = 0; i < Arrays_Size; i++)
            //{
            //    if (arr1[i] > max)
            //        max = arr1[i];

            //    if (arr1[i] < max && arr1[i] > secondLargest)
            //        secondLargest = arr1[i];
            //}

            //Console.WriteLine("The second largest element in the array is: " + secondLargest);

            #endregion

            #region Question_7

            //int Arrays_Size = ReadArraySize();
            //int[] arr = new int[Arrays_Size];
            //(arr) = ReadArray(Arrays_Size, arr);

            //int count = 1;
            //int max = int.MinValue;
            //bool flag = true;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (j == arr.Length)
            //        {
            //            break;
            //        }
            //        count++;
            //        if (arr[i] == arr[j])
            //        {
            //            if (count > max)
            //            {
            //                if( i != 0 && flag)
            //                {
            //                    count += 1;
            //                    flag = false;
            //                }
            //                max = count;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("The longest distance between two values in the array is: " + " with " + (max - 2)  + " elements between them !");

            #endregion

            #region Question_8

            //Console.Write("Enter text to reverse it: ");
            //string text = Console.ReadLine().ToString();
            //// split it by space
            //string[] words = text.Split(' ');
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + " ");
            //}

            #endregion

            #region Question_9

            //int row = 0;
            //int col = 0;
            //int value = 0;
            //Console.Write("Enter number of rows of the array: ");
            //if (int.TryParse(Console.ReadLine(), out int row_value))
            //{
            //    row = row_value;
            //}

            //Console.Write("Enter number of columns of the array: ");

            //if (int.TryParse(Console.ReadLine(), out int col_value))
            //{
            //    col = col_value;
            //}

            //Console.WriteLine("Enter the value to be added: ");

            //if (int.TryParse(Console.ReadLine(), out int input))
            //{
            //    value = input;
            //}

            //int[,] arr1 = new int[row, col];
            //int[,] arr2 = new int[row, col];

            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = value;
            //    }
            //}

            //arr2 = (int[,])arr1.Clone();

            //Console.WriteLine("The second array is: ");
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question_10

            //int row = 0;
            //int col = 0;

            //int[,] arr = new int[row, col];

            //Console.Write("Enter number of rows of the array: ");
            //if (int.TryParse(Console.ReadLine(), out int row_value))
            //{
            //    row = row_value;
            //}

            //Console.Write("Enter number of columns of the array: ");

            //if (int.TryParse(Console.ReadLine(), out int col_value))
            //{
            //    col = col_value;
            //}

            //for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            //{
            //    for (int j = arr.GetLength(1) - 1; j >= 0; j--)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region General

            #region Question_1

            //Console.WriteLine("Enter the principal amount: ");
            //if (double.TryParse(Console.ReadLine(), out double principal))
            //{
            //    Console.WriteLine("Enter the rate of interest: ");
            //    if (double.TryParse(Console.ReadLine(), out double rate))
            //    {
            //        Console.WriteLine("Enter the time period: ");
            //        if (double.TryParse(Console.ReadLine(), out double time))
            //        {
            //            double result = Calc_Simple_Interest(principal, rate, time);
            //            Console.WriteLine("The simple interest is: " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}

            #endregion

            #region Question_2

            //Console.WriteLine("Enter your height in meters: ");
            //if (double.TryParse(Console.ReadLine(), out double height))
            //{
            //    Console.WriteLine("Enter your weight in kilograms: ");
            //    if (double.TryParse(Console.ReadLine(), out double weight))
            //    {
            //        double result = Calc_BMI(height, weight);
            //        Console.WriteLine("Your BMI is: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}

            #endregion

            #region Question_3
            //double temperature = 0;
            //Console.WriteLine("Enter the temperature: ");
            //if (double.TryParse(Console.ReadLine(), out temperature))
            //{
            //    Console.WriteLine("The temperature in Celsius is: " + Check_Temperature(temperature));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}
            #endregion

            #region Question_4

            //Console.Write("Enter the day: ");
            //string day = Console.ReadLine();

            //Console.Write("Enter the month: ");
            //string month = Console.ReadLine();

            //Console.Write("Enter the year: ");
            //string year = Console.ReadLine();

            //Console.WriteLine($"Today's date: {day}, {month}, {year}");
            //Console.WriteLine($"Today's date: {day}/{month}/{year}");
            //Console.WriteLine($"Today's date: {day}-{month}-{year}");

            #endregion

            #region Question_5
            // the correct answer is C
            #endregion

            #endregion
        }
    }
}
