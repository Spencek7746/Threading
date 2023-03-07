using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many throws should each thread make?: ");
            string userThrow = Console.ReadLine();

            Console.WriteLine("How many threads should run?: ");
            string userThread = Console.ReadLine();

            List <Thread> threads = new List <Thread>(Int32.Parse(userThread));
            List <FindPiThread> list = new List <FindPiThread>(Int32.Parse(userThread));

            for(int i = 0; i < list.Count; i++)
            {
                FindPiThread findPi = new FindPiThread(Int32.Parse(userThrow));
                list.Add(findPi);
                Thread thread = new Thread(new ThreadStart(findPi.throwDarts));
                thread.Start();
                Thread.Sleep(16);
            }

            for(int i = 0; i < threads.Count; i++) 
            {
                threads[i].Join();
            }

            for(int i = 0; i < list.Count; i++) 
            {
                FindPiThread findPi = list[i];;
                Console.WriteLine(4 * (findPi.dartBoard / Int32.Parse(userThrow)));
            }
            Console.ReadLine();
        }
    }
}
