using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FactoryWorker : Worker
    {
        public void LeaveFactory()
        {
            Console.WriteLine("Leave!");
        }
    }
}
