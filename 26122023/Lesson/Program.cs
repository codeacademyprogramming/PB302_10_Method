using System;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowSalam();
            ShowSalam();
            ShowSalam();

            ShowText("Salam PB302");
            ShowFullname("Hikmet", "Abbasov");

            var fullname = MakeFullname("Nermin", "Abbasova");
            Console.WriteLine(fullname);

            var sumResult1 = Sum(34, 10);
            var sumResult2 = Sum(-4, 10);
            var sumResult3 = Sum(34, 100);

            Console.WriteLine(sumResult1);

            Console.WriteLine(IsEven(45));
            Console.WriteLine(IsEven(10));

            Console.WriteLine(HasA("Salam Hikmet"));

            string word = "SALAM";
            Console.WriteLine(CountChar(word,'M'));

            var wantedIndex = FindFirstIndex("salam",'s');
            Console.WriteLine($"wanted index: {wantedIndex}");

            int[] nums = new int[]{ 34, 5, 7, 8 };
            //int[] nums = { 34, 5, 7, 8 };
            var resultSumOfArr = Sum(new int[] { 34, 5, 7, 8 });

            Console.WriteLine(Sum(34,10));
            Console.WriteLine(Sum(34,5,76));

            Console.WriteLine(Sum(10,40));

            Console.WriteLine(FindFirstIndex("salam necesen?",'n'));

            Console.WriteLine(RemoveLeftSpace("    salam   necesen>"));
        }

        static void ShowSalam()
        {
            Console.WriteLine("salam");
        }

        static void ShowText(string str)
        {
            Console.WriteLine(str);
        }

        static void ShowFullname(string name, string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }

        static string MakeFullname(string name,string surname)
        {
            string fullname = $"{name} {surname}";
            return fullname;
        }

        static int Sum(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
        static int Sum(int num1,int num2,int num3=0)
        {
            return num1 + num2 + num3;
        }
        static double Sum(double num1,double num2)
        {
            return num1 + num2;
        }
        //Verilmis ededler siyahisindaki ededlerin cemini tapan alqoritm
        static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static bool IsEven(int num)
        {
            if (num % 2 == 0) 
                return true;
            else 
                return false;
        }


        //Verilmiş yazının içində A hərfinin olub olmadığını tapan method
        static bool HasA(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'A')
                {
                    return true;
                }
            }

            return false;
        }

        //Verilmis 3 ededden en boyuyunu tapan metod

        static int FindBiggest(int num1,int num2,int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3) return num1;
                else return num3;
            }
            else if (num2 > num3) return num2;
            else return num3;
        }

        //Verilmis yazida A herfinin sayini tapan method
        static int CountA(string text)
        {
            //int count = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'A')
            //    {
            //        count++;
            //    }
            //}
            //return count;
            return CountChar(text, 'A');
        }

        //Verilmis yazida verilmis chardan nece eded oldugunu tapan method
        static int CountChar(string text,char wantedChar)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == wantedChar)
                {
                    count++;
                }
            }
            return count;
        }

        //Verilmis yazida veilmis charin ilk indexini tapan method
        static int FindFirstIndex(string text,char wantedChar='A')
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == wantedChar) return i;
            }

            return -1;
        }

        //Verilmis ededler siyahisindaki verilmis ededin yerlesdiyi indexi tapan proqram
        static int FindFirstIndex(int[] arr,int wantedElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedElement) return i;
            }

            return -1;

        }

        static int FindFirstIndex(double[] arr, double wantedElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedElement) return i;
            }

            return -1;
        }

        static int FindLastIndex(int[] arr,int wantedElement)
        {
            for (int i = arr.Length-1; i>=0; i--)
            {
                if (arr[i] == wantedElement) return i;
            }

            return -1;
        }

        static int FindLastIndex(string str, char chr)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == chr) return i;
            }

            return -1;
        }
        //slm  
        //Verilmis yazidan evvelindeki bosluqlar silin yazi duzelden metod
        static string RemoveLeftSpace(string str)
        {
            string newStr = "";
            int startIndex = FindFirstNonSpaceIndex(str);

            if (startIndex == -1) return str;

            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }

            return newStr;
        }

        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }



    }
}
