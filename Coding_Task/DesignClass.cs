using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Star.Coding_Task
{
    class DesignClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    //Create Calculator
    class Calculator
    {
        //instance varible
        int a, b, c;


        //Member Method
        public void readdata()
        {
            Console.WriteLine("Enter two number");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        public void add()
        {
            c = a + b;
            Console.WriteLine("Addition=" + c);
        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("Substration =" + c);
        }
        public void mul()
        {
            c = a * b;
            Console.WriteLine("Multiplication =" + c);
        }
        public void div()
        {
            c = a % b;
            Console.WriteLine("Division=" + c);
        }
    }
    class CalTest
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.readdata();
            c1.add();
            c1.sub();
            c1.mul();
            c1.div();

        }
    }

    //Find out Reactangle
    class Rectangle
    {
        int length, breadth, area, perimeter;
        public void input()
        {
            Console.WriteLine("Enter Length and breadth");
            length = int.Parse(Console.ReadLine());
            breadth = int.Parse(Console.ReadLine());
        }
        public int calculatearea()
        {
            area = length * breadth;
            return area;
        }
        public int calculateperimeter()
        {
            perimeter = (length + breadth) * 2;
            return perimeter;
        }
        public void display()
        {
            Console.WriteLine("Area of Circle=" + area);
            Console.WriteLine("Area of Perimeter=" + perimeter);
        }
    }
    class ReactTest
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.input();
            int area = r.calculatearea();
            int perimeter = r.calculateperimeter();
            r.display();

        }
    }

    //Set time using hour min sec

    class Time
    {
        //instance varible
        int hour, min, sec;

        //Member method
        public void settime()
        {
            Console.WriteLine("Enter hour min and sec");
            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
        }
        public void showtime()
        {
            Console.WriteLine("hour=" + hour + ",min=" + min + "sec=" + sec);
        }

    }
    class TimeTest
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.settime();
            t.showtime();
        }
    }

    //Print number 1 to 50 if even print as is it if odd print square
    class PrintNumber
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 50; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Even No=" + i);
                }
                else
                {
                    int sqr = i * i;
                    Console.WriteLine("Odd Number Square=" + sqr);
                }

            }

        }
    }

    /*
    *****
    ****
    ***
    **
    **/


    class StarPattern
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
        }
    }

    /*12345
      1234
      123
      12
      1
      12
      123
      1234
      12345*/

    class NumberPattern
    {
        static void Main(string[] args)
        {
            for (int r = 5; r > 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine(" ");

            }
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine(" ");

            }
        }
    }

    /*   1
       2 2 2
     3 3 3 3 3
    4 4 4 4 4 4 4*/

    class NumberPattern1
    {
        /* static void Main(string[] args)
         {
             for (int r = 1; r <= 4; r++)
             {
                 for (int sp =3; sp>=r; sp--)
                 {
                     Console.Write(" ");
                 }
                 for (int c = r; c <= 4; c++)
                 {
                     Console.Write(c);
                 }

                 Console.WriteLine(" ");
             }
         }*/
        static void Main(string[] args)

        {

            for (int r = 1; r <= 4; r++)
            {
                for (int sp = 3; sp >= r; sp--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {

                    Console.Write(r);

                }
                Console.WriteLine();

            }
            for (int r = 2; r <= 4; r++)
            {

                for (int c = 1; c <= r; c++)
                {

                    Console.Write(r);

                }
                Console.WriteLine();

            }

        }
    }

    //Write a program to print all factors of given numbers
    class FactorNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    //Write a  program to check given number is trimorphic number or not
    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            int l = num;
            int c = cube % 10;
            if (num > 9)
            {
                l = num % 10;
            }
            if (c == l)
            {
                Console.WriteLine("trimorphic number ");
            }
            else
            {
                Console.WriteLine("not trimorphic number ");
            }
        }
    }

    //Write a program to check given number is spy number or not
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, mul = 1;
            while (num > 0)
            {
                int l = num % 10;
                sum = sum + l;
                mul = mul * l;
                num = num / 10;
            }
            if (sum == mul)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("Not spy number");
            }

        }
    }

    //find out Harshad number 

    class HarsadNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int l = num % 10;
                sum = sum + l;
                num = num / 10;
            }
            if (num % sum == 0)
            {
                Console.WriteLine("Harsad Number");
            }
            else
            {
                Console.WriteLine("Not Harsad Number");
            }

        }
    }

    //Write a program to print number from 1 to 100 such that when a number is factor

    class RedBlue
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }
        }

    }
    class Amicable
    {
        static void Main(string[] args)
        {
            int a = 220;
            int b = 284;
            int sum1 = 0, sum2 = 0;

            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (int i = 1; i <= b; i++)
            {
                if (b % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (a == sum2 && b == sum1)
            {
                Console.WriteLine("Amicable no");
            }
            else
            {
                Console.WriteLine("Not Amicable");
            }
        }
    }

    //property Method

    class Timep
    {
        //instance varible
        int hour, min, sec;

        //Construct 
        public Timep()
        {
            Console.WriteLine("Construter define");
        }
        public int Hour
        {
            set { this.hour = value; }
            get { return hour; }
        }
        public int Min
        {
            set { this.min = value; }
            get { return min; }
        }

        public int Sec
        {
            set { this.sec = value; }
            get { return sec; }
        }
    }
    class TimePTest
    {
        static void Main(string[] args)
        {
            Timep t1 = new Timep();
            Console.WriteLine("Enter Hour min and sec");
            t1.Hour = int.Parse(Console.ReadLine());
            t1.Min = int.Parse(Console.ReadLine());
            t1.Sec = int.Parse(Console.ReadLine());

            Console.WriteLine("Hour=" + t1.Hour + ",min=" + t1.Min + ",sec=" + t1.Sec);
        }
    }
    class ReactangleP
    {
        //instance varible
        int length, breadth, area, perimeter;

        //constructor
        public ReactangleP()
        {
            Console.WriteLine("Constructor calling");
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
        public int Area()
        {
            area = length * breadth;
            return area;
        }
        public int Perimeter()
        {
            perimeter = (length + breadth) / 2;
            return perimeter;

        }

    }
    class ReactP
    {
        static void Main(string[] args)
        {
            ReactangleP r = new ReactangleP();
            Console.WriteLine("Enter Length");
            r.Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            r.Breadth = int.Parse(Console.ReadLine());

            Console.WriteLine("Area=" + r.Area());
            Console.WriteLine("Perimeter=" + r.Perimeter());



        }
    }
    class CalculatorP
    {
        //insatnce varible
        int numone, numtwo, result;

        //constructor 
        public CalculatorP()
        {
            Console.WriteLine("Constructor calling");
        }
        public int NumOne
        {
            set { numone = value; }
            get { return numone; }

        }
        public int NumTwo
        {
            set { numtwo = value; }
            get { return numtwo; }

        }
        public void Add()
        {
            result = numone + numtwo;
            Console.WriteLine("Addition=" + result);

        }
        public void sub()
        {
            result = numone - numtwo;
            Console.WriteLine("Substration =" + result);
        }
        public void mul()
        {
            result = numone * numtwo;
            Console.WriteLine("Multiplication =" + result);
        }
        public void div()
        {
            result = numone % numtwo;
            Console.WriteLine("Division=" + result);
        }
    }
    class CalP
    {
        static void Main(string[] args)
        {
            CalculatorP c = new CalculatorP();
            Console.WriteLine("Enter NumOne and NumTwo");
            c.NumOne = int.Parse(Console.ReadLine());
            c.NumTwo = int.Parse(Console.ReadLine());
            c.Add();
            c.mul();
            c.div();
            c.sub();

        }
    }

    //OOPS concept program


    abstract class TeacherT
    {
        int tid;
        string namde;
        long mobileno;

        public TeacherT(int tid, string namde, long mobileno)
        {
            this.tid = tid;
            this.namde = namde;
            this.mobileno = mobileno;
        }
        public TeacherT() { }

        public int Tid { get => tid; set => tid = value; }
        public string Namde { get => namde; set => namde = value; }
        public long Mobileno { get => mobileno; set => mobileno = value; }

        public abstract void Salary();
    }
    class HourelyBased : TeacherT
    {
        int rate_per_h, hrs;

        public HourelyBased(int rate_per_h, int hrs)
        {
            this.rate_per_h = rate_per_h;
            this.Hrs = hrs;
        }
        public HourelyBased()
        { }

        public int Rate_per_h { get => rate_per_h; set => rate_per_h = value; }
        public int Hrs { get => hrs; set => hrs = value; }

        override public void Salary()
        {
            Console.WriteLine("Salary =" + rate_per_h * hrs);
        }
    }
    class SalaryBased : TeacherT
    {
        int sals = 0;
        public SalaryBased()
        {

        }
        public SalaryBased(int sal)
        {
            sals = sal;
        }
        override public void Salary()
        {
            Console.WriteLine("salary" + sals);
        }
    }
    class TestTeacher
    {
        static void Main(string[] args)
        {
            SalaryBased s = new SalaryBased();
            s.Salary();
        }

    }

    class EmployeeData
    {
        static void Main(string[] args)
        {
            string[] employee = { "Nikhil", "Jyoti", "Rajesh", "Asar", "Govind", "Prena", "shraddha", "Ram", "Raju", "shyam" };

            Console.WriteLine("List display");
            for (int i = 0; i < employee.Length; i++)
            {

                Console.WriteLine(employee[i]);

            }
            Array.Sort(employee);
            Console.WriteLine("ordered list");
            for (int i = 0; i < employee.Length; i++)
            {

                Console.WriteLine(employee[i]);

            }
            Array.Reverse(employee);

        }
    }

    class Digit
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 50, 84, 44, 40, 60, 70 };

            for (int i = 0; i <= num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("number ordered");

        }
    }
    class Duplicte
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 50, 40, 50 };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = i;
                if (num == i)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Averge
    {
        static void Main(string[] args)
        {
            int[] marks = { 100, 102, 105, 106, 108, 107 };
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum = sum + marks[i];
            }
            int result = sum / marks.Length;
            Console.WriteLine(result);
        }
    }


    class SingleValue
    {
        static void Main(string[] args)
        {
            int[] number = { 100, 105, 103, 104, 105, 106, 107, 108 };
            Array.Sort(number);

            Console.WriteLine("Single Value");
            for (int i = 0; i < number.Length; i++)
            {

                if (((i > 0) && (number[i] == number[i - 1])) || ((i < number.Length - 1) && (number[i] == number[i + 1])))
                {

                    continue;

                }
                else
                {

                    Console.WriteLine(number[i]);
                }
            }

        }
    }

    class CountChar
    {
        static void Main(string[] args)
        {
            string[] name = { "Rahul", "Mohit", "Naman", "Adity", "Roshani", "Abhay" };

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine(name[i] + "=" + name[i].Length);

            }
        }
    }


    //Return test task 

    //4.Create an array of 10 names sort in descending order

    class SortNames
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int num = int.Parse(Console.ReadLine());
            String[] str = new String[num];
            Console.WriteLine("enter names");
            for (int i = 0; i < num; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i <= str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    String temp = "";
                    if (str[i].CompareTo(str[j]) > 0)
                    {
                        temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine("sort in descending order");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }

    //1.Write a  program to find the duplicate words and their number of occurrences in a string

    class DuplicateString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            s = s.ToLower();
            string[] str = s.Split();

            for (int i = 0; i < str.Length; i++)
            {
                int c = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i].Equals(str[j]))
                    {
                        c++;
                    }

                }
                if (c > 1 && str[i] != "0")
                {
                    Console.WriteLine(str[i]);
                    Console.WriteLine(c);
                }

            }

        }
    }

    //2.Write a program to count the number of words in a string
    class NumberOfWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string s = Console.ReadLine();
            s = s.ToLower();
            char[] c = new char[s.Length];
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                count++;

            }
            Console.WriteLine("total word in string=" + count);
        }
    }

    //3.Write a  program to check whether two strings are anagram or not?

    class AngranOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter The Second String ");
            string str2 = Console.ReadLine();
            string s = str1.ToLower();
            string s1 = str2.ToLower();
            if (s.Length == s1.Length)
            {
                char[] ch1 = s.ToCharArray();
                char[] ch2 = s1.ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);
                string st = new string(ch1);
                string st2 = new string(ch2);

                if (st == st2)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Angram");
                }

            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }

    //6.Write a  program to convert uppercase string to lowercase
    class ConvertCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();
            s = s.ToUpper();
            Console.WriteLine("After Convert into Lowercase");
            string str = s.ToLower();
            Console.WriteLine(str);
        }
    }

    //7.	WAP to reverse the array itself, don’t print array in reverse – I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3] without using temporary array

    class ReverseArrray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("after reverse array element");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }

    // 9.WAP sort array elements in ascending order
    class AscendingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine("Ascending order array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
    //11.WAP to replace all negative value with its immediate left elements square. Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].

    class RemoveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Left Element Square");

            for (int i = 0; i < arr.Length; i++)
            {
                    if (arr[i] < 0)
                    {
                         arr[i]++;
                         Console.WriteLine(arr[i]*arr[i]);
                    }
                    else
                    {
                        Console.WriteLine(arr[i]);
                    }

            }

        }
    }

    //13.WAP to print all unique elements in the array
    class UniqueElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int option = -1;
            int[] arr1 = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr1[j] = option;
                    }
                }
                if (arr1[i] != -1)
                {
                    arr1[i] = count;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr1[i] == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

    //12.WAP to find min character in character array. Means e.g. arr[] = [‘A’, ‘D’, ‘E’, ‘x’, ‘z’, ‘R’], so min character is ‘A’
    class MinCharacter
    {
        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter the Character in an array");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = char.Parse(Console.ReadLine());

            }
            char min = ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] < min)
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("Minimum Character or Array is=" + min);

        }
    }
    //5.Write a program to find total number of alphabets, digits or special character in a string.
    class FindSymbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int digit = 0, ch = 0, spec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                

                if (s[i] >= 'A' && s[i] <= 'Z' || s[i] >= 'a' && s[i] <= 'z')
                {
                    ch++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    spec++;
                }
               
            }
            Console.WriteLine("number of alphabet="+ch);
            Console.WriteLine("number of digit="+digit);
            Console.WriteLine("special character="+spec);
        }
    }

    //8.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value
    class MergaArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array one size");
            int size = int.Parse(Console.ReadLine());
            int[] arrOne = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter array second size");
            int num = int.Parse(Console.ReadLine());
            int[] arrTwo = new int[num];
            for (int i = 0; i < num; i++)
            {
                arrTwo[i] = int.Parse(Console.ReadLine());
            }
            int a1 = arrOne.Length;
            int b1 = arrTwo.Length;
            int c = a1 + b1;
            int[] arrThird = new int[c];
            for (int i = 0; i < a1; i++)
            {
                arrThird[i]= arrOne[i];
            }
            for (int i = 0; i < b1; i++)
            {
                arrThird[a1+i]= arrTwo[i];
            }
            
            for (int i = 0; i < arrThird.Length; i++)
            {
                
                for (int j = i+1; j < arrThird.Length; j++)
                {
                    if (arrThird[i] != arrThird[j])
                    {
                        Console.WriteLine(arrThird[j]);
                    }
                }
            }
            
        }
    }

    //10.WAP to replace all the 0’s with 1’s in your array. Your array is [26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34].

    class changeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter arry size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <=0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("replace all the 0’s with 1’s in array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }


    // Simple programs

    //1. Write a  program to enter two numbers and find their sum.

    class SumNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2; 

            Console.WriteLine("Sum of two number="+sum);
        }
    }

    //3. Write a  program to enter length and breadth of a rectangle and find its Area
    class ReactangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter leangth and breadth");
            int len = int.Parse(Console.ReadLine());
            int breadth = int.Parse(Console.ReadLine());

            int area = len * breadth;
            Console.WriteLine("area of reactangle="+area);
        }
    }

    //Write a  program to enter base and height of a triangle and find its area..
    class TraingleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base and height");
            int ba = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = (ba * height) / 2;
            Console.WriteLine("Area of Traingle="+area);
        }
    }

    //5.Write a Program to calculate Square of given number

    class SquareOFNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int square = num * num;
            Console.WriteLine("Square of number="+square);
        }
    }

    //6. Write a Program to calculate cube of given number

    class CubeOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int cube = num * num * num;
            Console.WriteLine("Cube of number=" + cube);
        }
    }

    // 7.Write a program to enter length in centimeter and convert it into meter and kilometer.

    class ConvertToMeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length in Centimeter");
            float cm = float.Parse(Console.ReadLine());

            float meter = cm / 100;
            float kilometer = cm / 100000;

            Console.WriteLine("Centimetr into Meter="+meter);
            Console.WriteLine("Centimeter into kilometer="+kilometer);
        }
    }

    //  8.Write a Java program to enter marks of five subjects and calculate total, average and percentage.

    class CalculateMarks
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter The Five Subject Marks");
            for (int i = 0; i <marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());

            }
            int total = 0;
            
            for (int i = 0; i < marks.Length; i++)
            {
                total = total + marks[i];
            }
            int avg = total / marks.Length;
            float percentage = (float)(total/500.0)*100;
            Console.WriteLine("Sum of subjects="+total);
            Console.WriteLine("Avg of subject="+avg);
            Console.WriteLine("Percentage="+percentage);


        }
    }

    //9.Write a Java program to enter P, T, R and calculate Simple Interest.

    class SimpleInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle and rate of interest and time");
            int pi = int.Parse(Console.ReadLine());
            float interest = float.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            float si = pi * interest * times;

            Console.WriteLine("Simple Interest="+si);

        }
    }

    //10.Write a Java program to enter length and breadth of a rectangle and find its perimeter.

    class Perimeters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length and breadth");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int pri = 2*(l+b);

            Console.WriteLine("Perimeter ="+pri);
        }
    }


    //Collection Assignment for Medha Mam

    //1.WAP to add elements to and print content of it where Integer is used. In second List String is used.

    class Firsts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
           

            //create integer
            List<int> l1 = new List<int>();
     
            //create string list
            List<string> l2 = new List<string>();
           
            //number is integer
                l1.Add(num);
          
            //element is string
                l2.Add(str);
            

      
            Console.WriteLine("Integer List..........");
            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("String List...........");
            foreach (string sts in l2)
            {
                Console.WriteLine(sts);
            }

        }
    }

    //2.WAP add elements to List 0th location keep Integer, 1st location String now print each element and display contents.

    class DiffElement
    {
        static void Main(string[] args)
        {
            //create int list
            List<int> lst = new List<int>();

            //create string list
            List<string> l1 = new List<string>();

            l1.Add("Shyam");
            //add element in list

            lst.Add(10);
            lst.Add(20);
            lst.Add(30);
            lst.Add(42);
            lst.Add(92);

            //add string in 1 th postion
            /* lst.InsertRange(1,l1);*/

            lst.Insert(1, 'A');

            foreach(int item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }

    //3.WAP to create a new List, add some colors (string) and print the collection.

    class ColorList
    {
        static void Main(string[] args)
        {

            //create a new List
            List<string> lst = new List<string>(20);

            //add color in list
            lst.Add("Yellow");
            lst.Add("Green");
            lst.Add("White");
            lst.Add("Red");
            lst.Add("Black");
            lst.Add("Purple");

            //print all color collection
            foreach (string str in lst )
            {
                Console.WriteLine(str);
            }


        }
    }

    //4.WAP of swap two elements in an List

    class NumberSwap
    {

        static void Main(string[] args)
        {
            //create list
            List<int> lst = new List<int>();

            //Add number in list
            lst.Add(10);
            lst.Add(8);

            lst.ForEach(s => Console.WriteLine(s));
            int temp = lst[0];
            lst[0] = lst[1];
            lst[1] = temp;
            Console.WriteLine("After swaping......");
            lst.ForEach(s => Console.WriteLine(s));

        }
    }

    //5.WAP to replace the second element of an List with the specified element

    class NumberReplace
    {
        static void Main(string[] args)
        {
            //create integer list
            List<int> lst = new List<int>();

            //add number in list
            lst.Add(10);
            lst.Add(20);
            lst.Add(15);
            lst.Add(21);
            lst.Add(35);

            //print all list
            foreach (int num in lst)
            {
                Console.WriteLine(num);
            }

            //replace the 2 postion number
            lst.Insert(2,22);

            Console.WriteLine("After Replace element......");
            foreach (int num in lst)
            {
                Console.WriteLine(num);
            }
        }
    }

    //6.WAP to create List of Students and iterate over it.

    class StudentList
    {
        string name;
        string branch;
        int percentage;

        public StudentList(string name, string branch, int percentage)
        {
            this.name = name;
            this.branch = branch;
            this.percentage = percentage;
        }

        public override string ToString()
        {
            return "name=" + name + " Branch=" + branch + " Precentage=" + percentage;
        }

        public string Name { get => name; set => name = value; }
        public string Branch { get => branch; set => branch = value; }
        public int Percentage { get => percentage; set => percentage = value; }
    }
    class WithStudentList
    {
        static void Main(string[] args)
        {
            //Create Student List
            List<StudentList> st = new List<StudentList>();

            //add details in list
            st.Add(new StudentList("Raj","CSE",95));
            st.Add(new StudentList("Shyam","IT",90));
            st.Add(new StudentList("Govind","ET",92));
            st.Add(new StudentList("Rushi","ME",88));
            st.Add(new StudentList("Krushna","CSE",91));

            st.ForEach(s1 => Console.WriteLine(s1));
        }
    }

    //7.WAP to convert array to List.

    class ArrayToList
    {
        static void Main(string[] args)
        {
            //create array
            int[] num = { 10, 20, 77, 22, 33 };


            //Convert array to list

            List<int> lst = new List<int>(num);
            

            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

        }
    }

    //8.WAP to print list in reverse order.

    class WithReverse
    {
        static void Main(string[] args)
        {

            //create list
            List<int> lst = new List<int>();

            lst.Add(10);
            lst.Add(9);
            lst.Add(22);
            lst.Add(15);
            lst.Add(55);
            lst.Add(40);

            int temp = 0;

            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = i; j < lst.Count; j++)
                {
                    temp = lst[i];
                    lst[i] = lst[j];
                    lst[j] = temp;

                }
            }

            Console.WriteLine("Reverse order........");
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

        }
    }
    //9.WAP to sort the elements of List that contains String objects. Print List.
    class BookList:IComparable<BookList>
    {
        string bname;
        string author;
        int price;

        public BookList(string bname, string author, int price)
        {
            this.Bname = bname;
            this.Author = author;
            this.Price = price;
        }
        public override string ToString()
        {
            return "Bname=" + bname + " Author=" + author + " Price=" + price;
        }

        public int CompareTo(BookList other)
        {
            return this.bname.CompareTo(this.bname);
        }

        public string Bname { get => bname; set => bname = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }

        
    }

    class BookDetails
    {
        static void Main(string[] args)
        {
            //create Book list
            List<BookList> bk = new List<BookList>();

            //add book details in list
            bk.Add(new BookList("Java","Suninfo",150));
            bk.Add(new BookList("C#","Microsoft",125));
            bk.Add(new BookList("C++","Denict",155));
            bk.Add(new BookList("C","Denis Ritche",100));

            bk.Sort();
            foreach (BookList b in bk)
            {
                Console.WriteLine(b);
            }

        }
    }

    //10WAP to create a class Employee with (name, designation and age).
    //Now create and add Employee objects elements to List.
    //Sort the List by age in descending order and print List.

    class Employee :IComparable<Employee>
    {
        string ename;
        string designation;
        int age;

        public Employee(string ename, string designation, int age)
        {
            this.Ename = ename;
            this.Designation = designation;
            this.Age = age;
        }

        public override string ToString()
        {
            return "Ename=" + ename + "Designation=" + designation + "Age=" + age;
        }
        int IComparable<Employee>.CompareTo(Employee other)

        {
            return this.ename.CompareTo(this.ename);
        }

        public string Ename { get => ename; set => ename = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Age { get => age; set => age = value; }

        
    }

    class EmpList
    {
        static void Main(string[] args)
        {
            //create List

            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee("Rajesh","Java Developer",25));
            emp.Add(new Employee("Nagesh","Sap Developer",26));
            emp.Add(new Employee("Shakir", "Full stack", 28));
            emp.Add(new Employee("Krushna","UI Developer",25));
            emp.Add(new Employee("Rahul","Service Now",27));

            //sort list in descending order
            var sortedList = emp.OrderByDescending(s => s.Age);

            foreach (Employee e in sortedList)
            {
                Console.WriteLine(e);
            }
           
        }
    }

    //11.WAP to add elements to a Dictionary and print content of it.
    //Use int as Key and String as Value.
    //In second Dictionary add elements of String type as Key and Int as Value.

    class WithDictonary
    {
        static void Main(string[] args)
        {
            //create Dictonary Use int as Key and String as Value.

            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(1,"rajesh");
            dt.Add(2, "rupesh");
            dt.Add(3,"shyam");
            dt.Add(4,"akash");
            dt.Add(5, "govind");

            //print dictonary
            Console.WriteLine("Use int as Key and String as Value.......");
            foreach (KeyValuePair<int, string> st in dt)
            {
                Console.WriteLine(st.Key+" "+st.Value);
            }

            //create Second Dictonary
            Dictionary<string, int> d1 = new Dictionary<string, int>();

            d1.Add("raj",1);
            d1.Add("Shyam",2);
            d1.Add("krushna",3);
            d1.Add("suraj",4);
            d1.Add("amol",5);

            Console.WriteLine("Use of String type as Key and Int as Value.....");
            foreach (KeyValuePair<string, int> s in d1)
            {
                Console.WriteLine(s.Key+" "+s.Value);
            }
        }
    }

    //12.WAP to get only the Keys from a Dictionary.

    class OnlyKey
    {
        static void Main(string[] args)
        {
            //create Dictonary
            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(1, "rajesh");
            dt.Add(2, "rupesh");
            dt.Add(3, "shyam");
            dt.Add(4, "akash");
            dt.Add(5, "govind");

            //print dictonary
            Console.WriteLine("get Only key.......");
            foreach (KeyValuePair<int, string> st in dt)
            {
                Console.WriteLine(st.Key);
            }
        }
    }

    ////13.WAP to get only the Values from a Dictionary.
    class onlyValue
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();

            dt.Add(1, "rajesh");
            dt.Add(2, "rupesh");
            dt.Add(3, "shyam");
            dt.Add(4, "akash");
            dt.Add(5, "govind");

            //print dictonary
            Console.WriteLine("get Only Value.......");
            foreach (KeyValuePair<int, string> st in dt)
            {
                Console.WriteLine(st.Value);
            }
        }
    }

    //14.WAP to create a  Dictionary  using Custom class as key and any other object as value

    class bike
    {
        string bname;
        string model;
        int price;

        public bike(string bname, string model, int price)
        {
            this.Bname = bname;
            this.Model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            return " Bname=" + bname + " Model=" + model + " Price=" + price;
        }

        public string Bname { get => bname; set => bname = value; }
        public string Model { get => model; set => model = value; }
        public int Price { get => price; set => price = value; }
    }
    class BikeDict
    {
        static void Main(string[] args)
        {
            //create Dictonary for bike
            Dictionary<bike,int> b = new Dictionary<bike, int>();

            b.Add(new bike("Hero","Hero",90000),1);
            b.Add(new bike("Honda", "Sp", 95000), 2);
            b.Add(new bike("TVS", "Star", 75000), 3);
            b.Add(new bike("Bajaj", "Pulsor", 125000), 4);
            b.Add(new bike("Tvs", "Sport", 85000), 5);

            foreach (KeyValuePair<bike, int> bk in b)
            {
                Console.WriteLine(bk);
            }
        }
    }


    //15.WAP to create a Queue to add 5 objects and also remove first two and iterate over it. 

    class WithQueue
    {
        static void Main(string[] args)
        {
            //create Queue

            Queue<int> q = new Queue<int>();

            //add element in queue
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(25);
            q.Enqueue(15);
            q.Enqueue(18);

            //print element in queue
            Console.WriteLine("Without remove element in queue");
            foreach (int qs in q)
            {
                Console.WriteLine(qs);
            }

            //remove element in queue
            for (int i = 0; i < 2; i++)
            {
                q.Dequeue();
            }
           
            Console.WriteLine("after remove element in queue");
            foreach (int qs in q)
            {
                Console.WriteLine(qs);
            }
        }
    }

    //16.WAP to create a Stack to store some objects and iterate over it.Also show use od push,pop,peek.

    class Person
    {
        string pname;
        int age;

        public Person(string pname, int age)
        {
            this.Pname = pname;
            this.Age = age;
        }

       public  override string ToString()
        {
            return "name="+pname+" age="+age;
        }


        public string Pname { get => pname; set => pname = value; }
        public int Age { get => age; set => age = value; }
    }
    class WithStack
    {
        static void Main(string[] args)
        {
            //create Person type stack
            Stack<Person> st = new Stack<Person>();

            //push object in stack

            st.Push(new Person("amol",25));
            st.Push(new Person("Kavita",21));
            st.Push(new Person("Rani",22));
            st.Push(new Person("Jyoti",24));
            st.Push(new Person("Namdev",26));
            st.Push(new Person("Nagesh",28));
            st.Push(new Person("Krushna",22));

            foreach (Person p in st)
            {
                Console.WriteLine(p);
            }

            //Pop the element in list
            st.Pop();
            st.Peek();

            Console.WriteLine("After pop & peek operation.......");

            foreach (Person p in st)
            {
                Console.WriteLine(p);
            }
        }
    }
}