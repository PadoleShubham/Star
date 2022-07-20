using System;
using System.Collections.Generic;
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
}