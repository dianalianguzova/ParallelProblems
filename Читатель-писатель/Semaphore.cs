using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Читатель_писатель
{
    internal class Semaphore
    {
        private int n;
        private Queue<int> q;
        private AutoResetEvent waiter;
        public Semaphore(int n)
        {
            this.n = n;
            q = new Queue<int>();
            waiter = new AutoResetEvent(false);
        }

        public void wait(int i)
        {
            if (n > 0) n--;
            
            else
            {
                q.Enqueue(i);
                waiter.WaitOne();
            }
        }
        public void signal()
        {
            if (q.Count > 0)
            {
                q.Dequeue();
                waiter.Set();
            }

            else n++;      
        }
    }
}
