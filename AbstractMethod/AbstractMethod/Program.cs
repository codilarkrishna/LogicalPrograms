using AbstractMethod.DAL;
using AbstractMethod.InterviewPrograms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Program
    {
        static public void Main1()
        {
            Expression<Func<int, int, int>> exp = (N1, N2) => N1 + N2;
            Func<int, int, int> compExp = exp.Compile();
            int res = compExp(20, 40);
            Console.WriteLine(res);
            // Create an expression using expression lambda
            Expression<Func<int, int, int>> expression = (num1, num2) => num1 + num2;
            // Compile the expression
            Func<int, int, int> compiledExpression = expression.Compile();
            // Execute the expression. 
            int result = compiledExpression(3, 4);


            EmployeeDbContext context = new EmployeeDbContext();
            IEnumerable<Employee> list =
            context.Employees.Where(p =>
            p.Name.StartsWith("S"));

            foreach (var item in list)
            {
                Console.WriteLine(item.Name + " ");
            }
            list = list.Take<Employee>(4);

            

            IQueryable<Employee> list1 =
            context.Employees.Where(p =>
            p.Name.StartsWith("S"));
            foreach (var item in list1)
            {
                Console.WriteLine(item.Name + " ");
            }
            list1 = list1.Take<Employee>(4);

            

            List<int> intArray = new List<int>() {10,20,30,40,50 };
            Console.WriteLine(intArray.Sum());

            Console.WriteLine(intArray.Min());

            Console.WriteLine(intArray.Max());

            Console.WriteLine(intArray.Average());

            Console.WriteLine(intArray.Count());

            IList<string> stringList = new List<string>() {
                                     "Java Developer",
            ".Net Developer",
            "Graphics Designer",
            "Mean Stack Developer" ,
            "Java"};
            // LINQ Query Syntax  
            var result4 = stringList.Select(s => s);
            var result1 = stringList.Where(x => x == "Java Developer").First();
            var result2 = stringList.Where(x => x == "Java Developer").Take(1);
            var result3 = stringList.Where(x => x == ".Net Developer").Single();
            Console.WriteLine(result1);
            Console.WriteLine(result2.ToString());
            Console.WriteLine(result3);
            foreach (var item in result4)
            {
                Console.WriteLine(item + " ");
            }


            List<string> listString = new List<string> { "HI", "HI", "Hello" };

            var res5 = listString.Distinct().ToList();



            foreach (var item in res5)
            {
                Console.WriteLine(item +" ");
            }
            //MethodAA();
            //Imyinterface obj = new A11();
            //obj.print();
            //Imyinterface1 obj1 = new A11();
            //obj1.print();

            Console.ReadLine();

        }

        static void MethodAA()
        {

            string str = "Lorem lipsum et";

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo textInfo = new CultureInfo("en-US", true).TextInfo;

            // Changes a string to titlecase.
            Console.WriteLine("\"{0}\" to titlecase: {1}",
                              str,
                              textInfo.ToTitleCase(str));

            Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower()));

            string s = "krishna";
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            string res = new string(a);
            Console.WriteLine(res);
        }
        delegate int del(int x, int y);

        static public void MainA()
        {
            var a = 12;
            // a = "str"; complie time error
            dynamic b = 120;
            b = "tes"; // no error 

            A1 obj = new A2();
            obj.PrintInfo();
            obj.Print();

            demo obj1 = new demo();
            obj1.v1 = 1;
            obj1.v2 = 2;
            demo obj2;
            obj2 = obj1;
            obj2.v1 = 5;
            demo obj3 = new demo();
            obj3.v1 = 3;
            obj3.v2 = 4;
            obj2 = obj3;
            Console.WriteLine(obj1.v1);
            Console.WriteLine(obj1.v2);
            Console.WriteLine(obj2.v1);
            Console.WriteLine(obj2.v2);
            Console.WriteLine(obj3.v1);
            Console.WriteLine(obj3.v2);
            Console.ReadLine();

        }

        static public void MethodA()
        {
            GFG ob = new GFG("GeeksforGeeks", "GFG");
            Console.WriteLine("str3 value : {0} ", ob.str3);
            GFG ob1 = new GFG("GeeksforGeeks1", "GFG1");
            GFG ob2 = new GFG("GeeksforGeeks2", "GFG2");
            GFG ob3 = new GFG("GeeksforGeeks3", "GFG3", "TestStr3");
            GFG ob4 = new GFG("GeeksforGeeks3", "GFG3", "TestStr3");

            Console.WriteLine("str4 value : {0} ", GFG.str4);
            Console.WriteLine("str5 value : {0} ", GFG.str5);


            Console.ReadLine();
        }

    }

    public class SampleA
    {
        public void print()
        {
            Console.WriteLine("Hello From Base");
        }
    }
    public sealed class ClassABC 
    {
        //private ClassABC()
        //{

        //}
        public static void print1()
        {
            Console.WriteLine("Hello From Sealed");
        }
    }
    public class ClassAC
    {
        public void print111()
        {
            Console.WriteLine("Hello From Sealed");
        }
    }

    public sealed class ClassAB : ClassAC
    {
        public void print11()
        {
            Console.WriteLine("Hello From Sealed");
        }
    }

    class demo
    {
        public int v1;
        public int v2;
    }

    class A1
    {
        public void PrintInfo()
        {
            Console.WriteLine("Hello from A1");
        }
        public virtual void Print()
        {
            Console.WriteLine("Hello from A1");
        }
    }
    class A2 : A1
    {
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Hello from A2");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Hello from A2");
        }
    }
    interface Imyinterface
    {
        void print();
    }
    interface Imyinterface1
    {
        void print();
    }
    class A11 : Imyinterface, Imyinterface1
    {
        void Imyinterface.print()
        {
            Console.WriteLine("Hello");
        }
        void Imyinterface1.print()
        {
            Console.WriteLine("Hello 1");
        }
    }
   

}
