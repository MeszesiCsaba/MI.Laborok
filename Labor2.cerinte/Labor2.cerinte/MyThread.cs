using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Labor2.cerinte
{
    internal class MyThread
    {
        private Thread thread;
        private bool isRunning;

        private Action drawAction;

        public MyThread(Action drawAction)
        {
            this.drawAction = drawAction;
        }

        public void Start()
        {
            if (isRunning)
                return;

            isRunning = true;

            thread = new Thread(Run);
            thread.Start();
        }

        public void Stop()
        {
            isRunning = false;
            if(thread != null && thread.IsAlive)
            { 
                thread.Join();
            }
        }

        private void Run()
        {
            while (isRunning)
            {
                Thread.Sleep(100);

                if(drawAction != null)
                {
                drawAction();
                }
            }
        }
    }
}
