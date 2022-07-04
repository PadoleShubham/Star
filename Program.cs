using System;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ProgramOne
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    if (c % 2 == 0)
                    {
                        Console.Write("0");

                    }
                    else {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }

    }

    class ProgramTwo
    {
        static void Main(string[] args)

        {
            int k = 0;
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(k);
                    k++;

                }
                Console.WriteLine();
            }
        }
    }
    class ProgramThree
    {
        static void Main(string[] args)

        {

            for (int r = 1; r <= 5; r++)
            {
                for (int space = 4; space >= r; space--) {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                Console.WriteLine();
            }
        }
    }

    class ProgramFour
    {
        static void Main(string[] args)

        {

            for (int r = 1; r <= 10; r = r + 2)
            {
                for (int c = 1; c <= r; c++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }

    class ProgramFive
    {
        static void Main(string[] args)

        {
            int space;

            for (int r = 1; r <= 10; r = r + 2)
            {
                for (space = 10; space >= r; space--) {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }

    class ProgramSix
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Number");
            int line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= line; r++)
            {
                for (int c = 1; c < 2 * r; c++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }

    class ProgramSeven
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter Number");
            int line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= line; r++)
            {
                for (int sp = 1; sp <= line - r; sp++) {
                    Console.Write(" ");
                }
                for (int c = 1; c < 2 * r; c++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }

    class ProgramEight
    {
        static void Main(string[] args)

        {

            for (int r = 1; r <= 5; r++)
            {
                for (int space = 4; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);

                }
                for (int k = r - 1; k >= 1; k--) {
                    Console.Write(k);
                }
                Console.WriteLine();
            }


        }
    }

    class DoLoop
    {
        static void Main(string[] args)

        {
            String choice;
            do {
                Console.WriteLine("Enter two Number");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int sum = a + b;
                Console.WriteLine("Sum=" + sum);
                Console.WriteLine("Do you want to perfrom Addition Yes/No");
                choice = Console.ReadLine().ToLower();
            } while (choice == "Yes");


        }
    }

    class Student
    {
        string name;
        int psercentage;
        int passout;
        string branch;
        string technicalskill;


        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.name = "Shubham";
            s1.psercentage = 90;
            s1.passout = 2020;
            s1.branch = "CSE";
            s1.technicalskill = "Core Java";

            Student s2 = new Student();
            s2.name = "Nikhil";
            s2.psercentage = 90;
            s2.passout = 2020;
            s2.branch = "CSE";
            s2.technicalskill = "C#";

        }
    }

    class StudentInfo
    {
        //Instance Variable
        string name;
        int psercentage;
        int passout;
        string branch;
        string technicalskill;

        public void accept()
        {
            Console.WriteLine("Enter name,psertange,passout,branch,technical");
            name = Console.ReadLine();
            psercentage = int.Parse(Console.ReadLine());
            passout = int.Parse(Console.ReadLine());
            branch = Console.ReadLine();
            technicalskill = Console.ReadLine();

        }
        public void display() {
            Console.WriteLine("Name=" + name);
            Console.WriteLine("psercentage=" + psercentage);
            Console.WriteLine("Passout=" + passout);
            Console.WriteLine("Branch=" + branch);
            Console.WriteLine("Technical Skill=" + technicalskill);


        }



    }
    class Test {
        static void Main(string[] args)
        {
            StudentInfo s1 = new StudentInfo();
            s1.accept();
            s1.display();

        }
    }

    class Book {
        //Instance Varible
        string name;
        string author;
        int price;

        public void accept()
        {
            Console.WriteLine("Enter book name,author,price");
            name = Console.ReadLine();
            author = Console.ReadLine();
            price = int.Parse(Console.ReadLine());

        }

        public void display()
        {
            Console.WriteLine("Book Name=" + name);
            Console.WriteLine("Book Author=" + author);
            Console.WriteLine("Book Price=" + price);
        }
    }
    class BookTest
    {
        static void Main(string[] args)
        {

            Book b1 = new Book();
            b1.accept();
            b1.display();

            Book b2 = new Book();
            b2.accept();
            b2.display();

        }
    }

    class Calculator
    {
        int n1 = 10, n2 = 5;

        public void addition()
        {
            int sum = n1 + n2;
            Console.WriteLine("Sum=" + sum);

        }

        public int multi()
        {
            int mul = n1 + n2;
            return mul;
        }

        public float division()
        {
            int div = n1 / n2;
            return div;
        }

        public int subtract()
        {
            int sub = n1 - n2;
            return sub;
        }


    }

    class CalTest
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.addition();
            float d = c.division();
            int s = c.subtract();
            int m = c.multi();
            Console.WriteLine("div=" + d + ",sub=" + s + ",mult=" + m);

            /* Console.WriteLine("Multi="+c.multi());
             Console.WriteLine("Sub="+c.subtract());
             Console.WriteLine("Div="+c.division());*/

        }
    }

    class Factorial
    {
        int a;
        public void accept()
        {
            Console.WriteLine("Enter The Number");
            a = int.Parse(Console.ReadLine());

        }

        public int factorial()
        {
            int fa = 1;
            for (int i = 1; i <= a; i++) {
                fa = fa * i;
            }

            return fa;
        }

        public bool even()
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool prime()
        {
            int c = 0;

            for (int i = 2; i <= a / 2; i++) {

                if (a % i == 0) {

                    c++;
                    break;
                }
            }
            if (c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class FactText
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.accept();
            int factorial = f.factorial();
            bool e = f.even();
            bool p = f.prime();
            Console.WriteLine("Factorial Number=" + factorial);
            Console.WriteLine("even Number=" + e);
            Console.WriteLine("prime Number=" + p);

        }
    }

    class Account
    {
        //instance varible

        string name;
        int accno;
        string accouttype;
        int bal;


        public void insert()
        {
            Console.WriteLine("Enter User Name,account no,account type,bal");
            name = Console.ReadLine();
            accno = int.Parse(Console.ReadLine());
            accouttype = Console.ReadLine();
            bal = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Customer Name=" + name);
            Console.WriteLine("Account no=" + accno);
            Console.WriteLine("Account type=" + accouttype);
            Console.WriteLine("Balence=" + bal);
        }
        public void withdrawl()
        {
            Console.WriteLine("Enter the amount to withdeaw");
            int wamt = int.Parse(Console.ReadLine());
            if (wamt > bal)
            {
                Console.WriteLine("insufficient bal");
            }
            else {

                bal = bal - wamt;
                Console.WriteLine("withdrw successful");
                Console.WriteLine("After Withdraw");
                Console.WriteLine("The bal is" + bal);
            }

        }
        public int checkbal()
        {
            return bal;

        }
        public void doposit() {
            Console.WriteLine("Enter the amount to doposit");
            int dp = int.Parse(Console.ReadLine());
            bal = bal + dp;
            Console.WriteLine("After doposit bal=" + bal);
        }


    }
    class Bank
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.insert();
            a.display();

            Console.WriteLine(" select one withdraw/doposit");
            string user = Console.ReadLine().ToLower();
            if (user == "withdraw")
            {
                a.withdrawl();
            }
            else
            {

                a.doposit();
            }
            int c = a.checkbal();
            Console.WriteLine("cheakBal=" + c);

        }
    }

    class HDFC
    {
        protected int accno;
        protected string name;
        protected int bal;
        static float roi = 7.8f;

        public HDFC(int accno, string name, int bal)
        {
            this.accno = accno;
            this.name = name;
            this.bal = bal;
        }

        public void m1()
        {
            int a = 90;
        }
        static void m2()
        {

        }

        static void Main(string[] args)
        {
            HDFC h = new HDFC(1011, "shubham", 500);

        }
    }

    class Movieee
    {
        string moviname;
        int rating;


        //set value movie
        public void setMoviname(string mname)
        {
            moviname = mname;
        }
        public string getMoviename()
        {
            return moviname;
        }

        public void setRating(int r)
        {
            rating = r;
        }
        public int getRating()
        {
            return rating;
        }
    }
    class MovieTest
    {
        static void Main(string[] args)
        {
            Movieee m = new Movieee();
            m.setMoviname("ready");
            Console.WriteLine(m.getMoviename());
        }

    }

    class Restaurant
    {
        string reastaruntname;
        string area;
        long mobileno;
        int rating;

        //property method
        public string ReastaruntName
        {
            set { this.reastaruntname = value; }
            get { return reastaruntname; }
        }
        public string Area
        {
            set { this.area = value; }
            get { return area; }
        }

        public long MobileNo
        {
            set { this.mobileno = value; }
            get { return mobileno; }
        }
        public int Rating
        {
            set { this.rating = value; }
            get { return rating; }
        }
    }
    class RestaruntTest
    {
        static void Main(string[] args)
        {
            Restaurant r = new Restaurant();
            r.ReastaruntName = "Shubham";
            Console.WriteLine(r.ReastaruntName);
            r.Area = "Pune";
            Console.WriteLine(r.Area);
            r.MobileNo = 9876543210;
            Console.WriteLine(r.MobileNo);
            r.Rating = 4;
            Console.WriteLine(r.Rating);


        }
    }

    class Overloading
    {
        int a, b, c;
        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
                return c;
        }
    }
    class OverLoad
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Overloading.Max(20, 10));
            Console.WriteLine(Overloading.Max(20, 30, 10));

        }
    }
    class Pen
    {
        string name;
        string brand;
        string color;
        int price;

        public Pen()
        {
        }
        public Pen(string pnm)
        {
            name = pnm;
        }
        public Pen(string nm, string br, int pr)
        {
            name = nm;
            brand = br;
            price = pr;

        }
        public Pen(string nm, string br, string c, int pr)
        {
            name = nm;
            brand = br;
            color = c;
            price = pr;

        }
    }
    class PenTest
    {
        static void Main(string[] args)
        {
            Pen p = new Pen();
            Pen p1 = new Pen("Cello");
            Pen p2 = new Pen("Cello", "JellPen", 30);
            Pen p3 = new Pen("Ritreo", "jellpen", "red", 50);

        }
    }

    //Inheritance

    class Teacher
    {
        string tname;
        int salary;
        int experience;

        public Teacher()
        {
            Console.WriteLine("In Teacher const");
        }
        public Teacher(string name, int sal, int experience)
        {
            this.tname = name;
            this.salary = sal;
            this.experience = experience;

        }

        public string Tname
        {
            get => tname;
            set => tname = value;

        }
        public int Salary
        {
            get => salary;
            set => salary = value;
        }
    }

    class VisitingTeacher : Teacher
    {
        int hrs, rates;
        public VisitingTeacher(int hr, int r)
        {
            this.hrs = hr;
            this.rates = r;

        }
    }

    class Pen1
    {
        string brand;
        int cost;
        string color;

        public Pen1(string brand, int cost, string color)
        {
            this.brand = brand;
            this.cost = cost;
            this.color = color;
        }
        public Pen1()
        {
        }
        public void write()
        {

        }
        public string Brand
        {
            set { this.brand = value; }
            get { return brand; }

        }
        public string Color
        {
            set => color = value;
            get => color;

        }
        public int Cost
        {
            set => cost = value;
            get => cost;

        }


    }

    class CompassBox
    {
        string compass_brand;
        int price;

        static void Main(string[] args)
        {
            CompassBox c = new CompassBox();
            c.compass_brand = "apsra";
            c.price = 200;

        }
    }

    class Customer
    {
        string name;
        long mo;
        public Customer(string name, long mo)
        {
            this.name = name;
            this.mo = mo;
        }
        public string Name
        {
            set => name = value;
            get => name;
        }
        public long Mo
        {
            set => mo = value;
            get => mo;
        }



    }

    class Item
    {
        string itemname;
        int itemprice;
        int quantiry;

        public Item(string itemname, int itemprice, int quantiry)
        {
            this.Itemname = itemname;
            this.Itemprice = itemprice;
            this.Quantiry = quantiry;
        }

        public string Itemname { get => itemname; set => itemname = value; }
        public int Itemprice { get => itemprice; set => itemprice = value; }
        public int Quantiry { get => quantiry; set => quantiry = value; }
    }
    class Order
    {
        int orderid;
        int odate;
        Customer cust;
        Item item;

        public int Odate { get => odate; set => odate = value; }
        public int Orderid { get => orderid; set => orderid = value; }

        static void Main(string[] args)
        {
            Order r = new Order();
            r.orderid = 222;
            r.Odate = 25 / 10 / 2022;
            r.cust = new Customer("Shubham", 8329641682);
            r.item = new Item("Laptop", 45000, 2);
            Console.WriteLine(r.cust);
        }


    }

    class WebDeveloper
    {
        string name;
        string skill;
        int sal;

        public WebDeveloper(string name, string skill, int sal)
        {
            this.Name = name;
            this.Skill = skill;
            this.Sal = sal;
        }

        public string Name { get => name; set => name = value; }
        public string Skill { get => skill; set => skill = value; }
        public int Sal { get => sal; set => sal = value; }
    }
    class Developer
    {
        WebDeveloper dev;
        static void Main(string[] args)
        {
            Developer d = new Developer();
            d.dev = new WebDeveloper("Shubham", "Angular", 2500);
        }
    }


    //inheritance program


    //Developer

    class Devloper1
    {
        string name;
        string skill;
        int sal;
        int experince;

        public Devloper1()
        {
            Console.WriteLine("Develoepr Const");
        }

        public Devloper1(string name, string skill, int sal, int experince)
        {
            this.Name = name;
            this.Skill = skill;
            this.Sal = sal;
            this.Experince = experince;
        }

        public string Name { get => name; set => name = value; }
        public string Skill { get => skill; set => skill = value; }
        public int Sal { get => sal; set => sal = value; }
        public int Experince { get => experince; set => experince = value; }
    }

    class WebDeveloper1 : Devloper1
    {

        string compnay_name;
        public WebDeveloper1()
        {
            Console.WriteLine("Web Developer Cont");
        }

        public WebDeveloper1(string compnay_name)
        {
            this.compnay_name = compnay_name;
        }

        public string Compnay_name { get => compnay_name; set => compnay_name = value; }
    }
    class TextDeveloper
    {
        static void Main(string[] args)
        {
            WebDeveloper1 w = new WebDeveloper1("TQ");
            Console.WriteLine("Company Name=" + w.Compnay_name);

        }
    }

    class Parent
    {
        string name;
        public void play()
        {
            Console.WriteLine("Play ");
        }
        public virtual void study()
        {
            Console.WriteLine("Read book");
        }
    }

    class Child : Parent
    {
        public override void study()
        {
            Console.WriteLine("Learn watching videos");
        }
    }
    class Tset
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.study();
            Child c = new Child();
            c.study();
            Parent p1 = new Child();
            p1.study();

        }
    }

    // Sealed Keyword

    class PPPP
    {
        public virtual void m1()
        {
            Console.WriteLine("parent m1");
        }

    }

    class CC : PPPP
    {
        public override void m1()
        {
            Console.WriteLine("second child m1");
        }

    }

    class CC3 : CC
    {
        public override void m1()
        {
            Console.WriteLine("thhird child m1");
        }

        static void Main(string[] args)
        {
            PPPP ob = new PPPP();
            ob.m1();
        }
    }

    class stud
    {
        int id;
        string name;
        int percentage;

        public stud(int id, string name, int percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
        }

        public override string ToString()
        {
            return $"id:{id}name:{name} percentage:{percentage}";
        }

        static void Main(string[] args)
        {
            stud s = new stud(1, "raj", 30);
            Console.WriteLine(s);
            //inteally call ToString Method
        }
    }


    abstract class Teacher1
    {
        string name;
        int exp;


        public string Name { get => name; set => name = value; }
        public int Exp { get => exp; set => exp = value; }

        public Teacher1(string name, int exp)
        {
            this.name = name;
            this.exp = exp;
        }

        public Teacher1()
        {

        }

        public abstract void CalculateSalary();


    }

    class PermentantTeacher : Teacher1
    {
        int salary;
        PermentantTeacher()
        {

        }
        public override void CalculateSalary()
        {
            Console.WriteLine("salary" + salary);
        }
    }
    class VisitingTeacher11 : Teacher1
    {
        int hrss, rate;

        public int Hrss { get => hrss; set => hrss = value; }
        public int Rate { get => rate; set => rate = value; }

        override public void CalculateSalary()
        {
            Console.WriteLine("salary" + Hrss * Rate);
        }
    }

    class TTT
    {
        static void Main(string[] args)
        {
            VisitingTeacher11 v = new VisitingTeacher11();
            v.CalculateSalary();
        }
    }

    class FindMax
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine($"enter {num.Length} element in array");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int max = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
            }
            Console.WriteLine("Max=" + max);
        }
    }

    class SortArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size of Array");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"enter {arr.Length} element in array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int temp = 0;
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("sorted array=" + arr[i]);
            }
        }
    }

    //assignment question

    class SumOfEven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Size of Array");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine($"enter {arr.Length} element in array");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];

                }

            }
            Console.WriteLine("sum of even number in array=" + sum);
        }
    }

    class SumOfArray
    {
        static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("enter array size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array=" + sum);

        }
    }
    class AlterNavtiveElement
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
            Console.WriteLine("alter native elemnet");
            int alter = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (alter == arr[i])
                {
                    Console.WriteLine("alter native element find=" + arr[i]);
                }

            }

        }
    }

    class MinElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter the arrar element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("min Value=" + min);
        }
    }

    class ReverseChar
    {
        static void Main(string[] args)
        {
            char[] ch = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine("reverse character");
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ch[i]);
            }

        }
    }

    class CheckPrime
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            Console.WriteLine("Enter Array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }





    // wap to caluculate avg of alternate from array

    class AvgArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int avg = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i = i + 1)
            {

                sum = sum + arr[i];


            }
            avg = sum / arr.Length;
            Console.WriteLine("avg=" + avg);


        }
    }

    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];
            int[] arr2 = new int[num];

            Console.WriteLine("enter the element");
            for (int i=0;i<num;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("after copy array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
                Console.WriteLine(arr2[i]);
            }
           
        }
    }

    class CountDuplicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter the array element");
            for (int i=0;i<num;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;

                    }

                }
            }
            Console.WriteLine("duplicate number="+count);

        }

    }

    class UniqueElemnet
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
                for (int j = i +1; j < arr.Length; j++)
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
            for(int i =0;i<arr.Length;i++)
            {
                if(arr1[i] == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

    class NegativeNumber
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
            for (int i=0; i < arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
    class CountNegative
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
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Negative Number="+count);

        }
    }
    class MaxMin
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
            int max = arr[0];
        
            for (int i = 0; i <arr.Length; i++)
            {
                if (max <arr[i])
                {
                    max = arr[i];
                }
            
            }
            Console.WriteLine(max);
            



        }
    }

    class Star1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r < 5; r++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
            
        }
    }

    class MethodOverload
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public float add(float a, float b)
        {
            return a + b;
        }

        public static void Main()
        {
            MethodOverload m = new MethodOverload();
            Console.WriteLine("addition of int number =" + m.add(10, 20));
            Console.WriteLine("additon of float nunber="+m.add(1.2f,3.1f));
        }
    }

    class TastOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array of size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("enter array element");
            for (int i = 0; i < num; i++)
            { 
               arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }



}
 

