using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.InterviewPrograms
{
    public class One:IDisposable
    {
        public One()
        {
            Console.WriteLine("FromOne");
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~One() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
             GC.SuppressFinalize(this);
        }
        #endregion
    }

    class SampleOne:One
    {
        public static int V1;
        public static int V2;
        public static int V3;
        
        
        static SampleOne()
        {
           // this.V1 = 10;
            V2 = 20;
            V3 = 30;
        }
        public SampleOne()
        {
            var res= this.GetHashCode();
            Console.WriteLine("FromSample");
        }
        static public void Main2()
        {
            SampleOne sampleOne = new SampleOne();


            Console.ReadLine();
        }
      
    }
}
