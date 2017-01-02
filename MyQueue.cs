using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public class MyQueue<T>
    {
        private ManagerNodeAbstract<T> myCollection;

        public MyQueue()
        {
            myCollection = new ManagerNodeSimple<T>();
        }

        public MyQueue(ManagerNodeAbstract<T> collection)
        {
            myCollection = collection;
        }

        public T Peek
        {
            get
            {
                return myCollection.root.Value;
            }
        }

        public int Count
        {
            get
            {
                return myCollection.CountNode;
            }
        }

        public void Clear()
        {
            myCollection.ClearNode();
        }

        public void Enqueue(T item)
        {
            myCollection.AddNode(item);
        }

        public void Dequeue()
        {
            myCollection.RemoveAtNode(0);
        }
    }
}
