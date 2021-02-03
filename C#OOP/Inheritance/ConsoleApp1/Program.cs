using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            Worker worker = new Worker("com", "sf");
            Console.WriteLine(worker.Name);
            Console.WriteLine(worker.Company);
            //Student st = new Student();

            //Worker worker = new Worker();
            //worker.Name = "Pesho";

            //worker.Sleep();

            //FactoryWorker factoryWorker = new FactoryWorker();
            //factoryWorker.LeaveFactory();
            //factoryWorker.Sleep();
        }
    }
}
