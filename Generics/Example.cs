using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading;

namespace Generics
{
    public class Example <T>
    {
        private T enter;
        //public Example(T e)
        //{
        //    this.enter = e;
        //}
     
        //public T GetEnter()
        //{
        //    return this.enter;
        //}
        public T e
        {
            get { return this.e; }
            set { this.e = value; }
        }
    }
}
