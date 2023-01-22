using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    
    class User
    {
        private User()
        {
            Console.WriteLine("I am Private Constructor");
        }
        public static string name, location;
        SamplePrivateConst samplePrivateConst = new SamplePrivateConst();
        public User(string a, string b)
        {
            name = a;
            location = b;
            samplePrivateConst.NestedMethod();
        }
        class SamplePrivateConst
        {
            public void NestedMethod()
            {
                User user = new User();
                Console.WriteLine("I am nested Method");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Suresh Dasari", "Hyderabad");
            Console.WriteLine(User.name + ", " + User.location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
