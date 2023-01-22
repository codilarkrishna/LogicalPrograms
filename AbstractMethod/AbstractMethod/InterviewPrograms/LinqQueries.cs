using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class LinqQueries
    {
        public static void LinqMethodA()
        {

            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            


            IEnumerable<int> queryResult = from num in intList
                                           where num > 5 && num < 10
                                           select num;

            foreach (var item in queryResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var Res = intList.Where(num => num > 5 && num < 10);

            foreach (var item in Res)
            {
                Console.Write(item + " ");
            }

        }
    }
}
