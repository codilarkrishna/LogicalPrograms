using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class SampleTwo
    {
    }
    class Employee1
    {
        private string name;
        private string alias;
        private decimal salary = 3000.00m;

        // Constructor:
        public Employee1(string name, string alias)
        {
            // Use this to qualify the fields, name and alias:
            this.name = name;
            this.alias = alias;
        }

        // Printing method:
        public void printEmployee()
        {
            Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
            // Passing the object to the CalcTax method by using this:
            Console.WriteLine("Taxes: {0}", Tax.CalcTax(this));
        }

        public decimal Salary
        {
            get { return salary; }
        }
    }

    class Tax
    {
        public static decimal CalcTax(Employee1 E)
        {
            return 0.08m * E.Salary;
        }
    }

    class MainClass1
    {
        static void Main3()
        {
            // Create objects:
            Employee1 E1 = new Employee1("Mingda Pan", "mpan");

            // Display results:
            E1.printEmployee();

            Console.ReadLine();
        }
    }
    /*
    Output:
        Name: Mingda Pan
        Alias: mpan
        Taxes: $240.00
     */
}
