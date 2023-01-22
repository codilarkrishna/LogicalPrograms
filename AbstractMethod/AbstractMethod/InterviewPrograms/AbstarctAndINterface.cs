using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    class AbstarctAndINterface
    {
    }
    abstract class abstract11
    {
    }
    abstract class abstract12
    {
        public abstract void abs11();
    }

    interface  Imyinterface11
    {
        void p1();
        void p2();
        int p3();
    }

    interface Imyinterface12
    {
    }

    class golbal1 : abstract12, Imyinterface12, Imyinterface11
    {
        public override void abs11()
        {
            throw new NotImplementedException();
        }

        public void p1()
        {
            throw new NotImplementedException();
        }

        public void p2()
        {
            throw new NotImplementedException();
        }

        public int p3()
        {
            throw new NotImplementedException();
        }

       
    }
    //class golbal12 : Imyinterface12, Imyinterface11
    //{

    //}
}
