using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerNodeSimple<int> manager = new ManagerNodeSimple<int>();
            MyQueue<int> myQueue = new MyQueue<int>(manager);
            
            for(int i = 1; i < 10; i++)
            {
                myQueue.Enqueue(i);
            }

            Console.WriteLine(myQueue.Peek);

            myQueue.Dequeue();

            Console.WriteLine(myQueue.Peek);

            Console.ReadLine();
        }
    }
}
