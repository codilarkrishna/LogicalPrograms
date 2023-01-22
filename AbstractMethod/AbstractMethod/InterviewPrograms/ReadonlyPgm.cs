using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class ReadonlyPgm
    {
        public int num = 10;
        public readonly int num2;
        public ReadonlyPgm()
        {
            num2 = 100;
        }
        public void MethodA()
        {
            num2 = 200;        }
        
    }
}
