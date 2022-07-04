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
               
                Console.WriteLine(name[i] + "=" +name[i].Length);

            }
        }
    }
    
}
