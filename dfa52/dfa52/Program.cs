using System;
using System.Linq;
namespace ConsoleApp10
{
    class Program
    {
        
        delegate int SumDelegate(int a, int b);
        static int Sum(int a, int b) => a + b;

        
        delegate int LengthDelegate(string str);
        static int GetLength(string str) => str.Length;

        
        delegate int MaxDelegate(int[] arr);
        static int GetMax(int[] arr) => arr.Length == 0 ? 0 : arr.Max();

        delegate double MultiplyDelegate(double a, double b);
        static double Multiply(double a, double b) => a * b;

        
        delegate string ToUpperDelegate(string str);
        static string ToUpperCase(string str) => str.ToUpper();

       
        delegate int SubtractDelegate(int a, int b);
        static int Subtract(int a, int b) => a - b;

        
        delegate string JoinStringsDelegate(string[] arr);
        static string JoinStrings(string[] arr) => string.Join(",", arr);

        
        delegate double DivideDelegate(double a, double b);
        static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return a / b;
        }

        
        delegate bool PalindromeDelegate(string str);
        static bool IsPalindrome(string str)
        {
            string reversed = new string(str.Reverse().ToArray());
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        
        delegate double AverageDelegate(int[] arr);
        static double GetAverage(int[] arr) => arr.Length == 0 ? 0 : arr.Average();

        
        delegate int VowelCountDelegate(string str);
        static int VowelCount(string str)
        {
            string vowels = "aeiouAEIOU";
            return str.Count(c => vowels.Contains(c));
        }

       
        delegate int GcdDelegate(int a, int b);
        static int GetGcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        
        delegate string[] SortStringsByLengthDelegate(string[] arr);
        static string[] SortStringsByLength(string[] arr) => arr.OrderBy(s => s.Length).ToArray();

        
        delegate string ReverseStringDelegate(string str);
        static string ReverseString(string str) => new string(str.Reverse().ToArray());

       
        delegate bool GreaterThanDelegate(int a, int b);
        static bool IsGreaterThan(int a, int b) => a > b;

       
        delegate int EvenCountDelegate(int[] arr);
        static int EvenCount(int[] arr) => arr.Count(n => n % 2 == 0);

       
        delegate char FirstLetterDelegate(string str);
        static char FirstLetter(string str) => str.Length > 0 ? str[0] : '\0';

       
        delegate double SqrtDelegate(double a, double b);
        static double Sqrt(double a, double b) => Math.Sqrt(a * b);

        
        delegate string JoinStringsWithSpaceDelegate(string[] arr);
        static string JoinStringsWithSpace(string[] arr) => string.Join(" ", arr);

       
        delegate bool IsNumericDelegate(string str);
        static bool IsNumeric(string str) => str.All(char.IsDigit);

        static void Main()
        {
            Console.WriteLine("Введите номер задания от 1 до 20:");
            int taskNumber = int.Parse(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:
                    Console.WriteLine("Сумма: " + Sum(5, 3));
                    break;
                case 2:
                    Console.WriteLine("Длина строки: " + GetLength("Hello"));
                    break;
                case 3:
                    Console.WriteLine("Максимум: " + GetMax(new int[] { 1, 3, 7, 2 }));
                    break;
                case 4:
                    Console.WriteLine("Произведение: " + Multiply(5.5, 3.3));
                    break;
                case 5:
                    Console.WriteLine("Верхний регистр: " + ToUpperCase("hello"));
                    break;
                case 6:
                    Console.WriteLine("Разность: " + Subtract(8, 3));
                    break;
                case 7:
                    Console.WriteLine("Объединенные строки: " + JoinStrings(new string[] { "apple", "banana", "cherry" }));
                    break;
                case 8:
                    try
                    {
                        Console.WriteLine("Деление: " + Divide(10, 2));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 9:
                    Console.WriteLine("Палиндром: " + IsPalindrome("madam"));
                    break;
                case 10:
                    Console.WriteLine("Среднее значение: " + GetAverage(new int[] { 1, 2, 3, 4, 5 }));
                    break;
                case 11:
                    Console.WriteLine("Количество гласных: " + VowelCount("hello world"));
                    break;
                case 12:
                    Console.WriteLine("НОД: " + GetGcd(56, 98));
                    break;
                case 13:
                    string[] sortedStrings = SortStringsByLength(new string[] { "apple", "pear", "banana", "kiwi" });
                    Console.WriteLine("Отсортированные строки: " + string.Join(", ", sortedStrings));
                    break;
                case 14:
                    Console.WriteLine("Обратный порядок: " + ReverseString("hello"));
                    break;
                case 15:
                    Console.WriteLine("Большее число: " + IsGreaterThan(5, 3));
                    break;
                case 16:
                    Console.WriteLine("Количество четных чисел: " + EvenCount(new int[] { 1, 2, 3, 4, 5, 6 }));
                    break;
                case 17:
                    Console.WriteLine("Первая буква: " + FirstLetter("hello"));
                    break;
                case 18:
                    Console.WriteLine("Квадратный корень: " + Sqrt(16, 25));
                    break;
                case 19:
                    Console.WriteLine("Объединенные строки: " + JoinStringsWithSpace(new string[] { "apple", "banana", "cherry" }));
                    break;
                case 20:
                    Console.WriteLine("Цифры: " + IsNumeric("12345"));
                    break;
                default:
                    Console.WriteLine("Неверный номер задания.");
                    break;
            }
        }
    }
}