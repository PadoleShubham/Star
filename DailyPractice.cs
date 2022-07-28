using System;
using System.Collections.Generic;
using System.Text;

namespace Star
{
    class DailyPractice
    {
        static void Main(string[] args)
        {
            //create list

            List<string> lst = new List<string>(10);

            //add item in list using add
            lst.Add("Akash");
            lst.Add("Rajesh");
            lst.Add("nagesh");
            lst.Add("Govind");
            lst.Add("shyam");



            //print all item in list
            foreach (string str in lst)
            {
                Console.WriteLine(str);
            }

            //insert the item using insert method
            lst.Insert(2, "vinod");

            Console.WriteLine("After insert item");
            foreach (string str in lst)
            {
                Console.WriteLine(str);
            }

        }
    }

    class WithRemove
    {

        static void Main(string[] args)
        {
            //create integer list
            List<int> lst = new List<int>();

            //added item in list
            lst.Add(10);
            lst.Add(30);
            lst.Add(20);
            lst.Add(40);

            //print all element in list

            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }

            //Remove element using remove method
            lst.Remove(10);

            //Remove element using removeAt method

            lst.RemoveAt(2);

            Console.WriteLine("After removing element");
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }
        }

    }

    class WithIndexOf
    {
        static void Main(string[] args)
        {
            //create integer list
            List<int> lst = new List<int>();

            //added item in list
            lst.Add(10);
            lst.Add(30);
            lst.Add(20);
            lst.Add(40);

            //find index using IndexOf

            int idx = lst.IndexOf(30);
            Console.WriteLine(idx);

            //find last indexOf

            int idx1 = lst.LastIndexOf(20);
            Console.WriteLine(idx1);

          

        }
    }

    class WithRange
    {
        static void Main(string[] args)
        {
            //old list
            List<int> l1 = new List<int>();

            l1.Add(10);
            l1.Add(20);
            //create new integer list
            List<int> lst = new List<int>();

            //added item in list
            lst.Add(30);
            lst.Add(40);
            lst.Add(60);
            lst.Add(50);

            //add hole list into new list using AddRange()
            l1.AddRange(lst);

            //print list after addrange
            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }

        }
    }

    class WithInsertRange
    {
        static void Main(string[] args)
        {
            //new list
            List<int> l1 = new List<int>();

            l1.Add(10);
            l1.Add(20);
            //create old integer list
            List<int> lst = new List<int>();

            //added item in list
            lst.Add(30);
            lst.Add(40);
            lst.Add(60);
            lst.Add(50);

            //added new list into old list using InsertRange()

            lst.InsertRange(2, l1);

            //print hole list after insert
            foreach (int item in lst)
            {
                Console.WriteLine(item);
            }


            //using Contains return bool
            bool b = lst.Contains(60);
            Console.WriteLine(b);
        }
    }

    class WithFindAll
    {
        //create function
        static bool isEven(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            //create list
            List<int> lst = new List<int>(){ 21,28,30,31,44,55,60};

            //create even number list using findAll() 
            List<int> l1 = lst.FindAll(isEven);

            //print all even element

            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }

           
        }
    }

    class Dept
    {
        string dname;
        public Dept(string dname)
        {
            this.dname = dname;
        }
        public string Dname
        {
            get => dname;
            set => dname = value;
        }
    }
    class Emp
    {
        int id;
        string ename;
        Dept d;

       

        public override string ToString()
        {
            return $"ID:{Id} Name:{Ename} Deptname:{D.Dname}";
        }

        public Emp(int id, string ename, Dept d)
        {
            this.Id = id;
            this.Ename = ename;
            this.D = d;
        }

        public int Id { get => id; set => id = value; }
        public string Ename { get => ename; set => ename = value; }
        internal Dept D { get => d; set => d = value; }
    }

    class TestEmp
    {
        static void Main(string[] args)
        {
            LinkedList<Emp> l1 = new LinkedList<Emp>();
            l1.AddLast(new Emp(1,"AA",new Dept("IT")));
            l1.AddLast(new Emp(2, "BB", new Dept("Sales")));
            l1.AddLast(new Emp(3, "CC", new Dept("Testing")));
            l1.AddLast(new Emp(4, "DD", new Dept("IT")));
            l1.AddLast(new Emp(5, "EE", new Dept("Sales")));
            l1.AddLast(new Emp(6, "FF", new Dept("IT")));
            l1.AddLast(new Emp(7, "GG", new Dept("Testing")));

            string dname = "";
            foreach (Emp e in l1)
            {
                if (e.Id == 10)
                {
                    dname = e.D.Dname;
                    break;
                }
              
            }

            foreach (Emp e in l1)
            {
                if (e.D.Dname==dname)
                {
                    l1.Remove(e);
                }
            }

        }
    }
}
