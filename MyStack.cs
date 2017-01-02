using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public class MyStack<T>
    {
        private ManagerNodeAbstract<T> myCollection;

        public MyStack()
        {
            myCollection = new ManagerNodeSimple<T>();
        }

        public MyStack(ManagerNodeAbstract<T> collection)
        {
            myCollection = collection;
        }

        public int Count
        {
            get
            {
                return myCollection.CountNode;
            }
        }

        public T Peek
        {
            get
            {
                return myCollection.root.Value;
            }
        }

        public void Push(T item)
        {
            myCollection.InsertNode(0, item);
        }

        public void Pop()
        {
            myCollection.RemoveAtNode(0);
        }

    }
}
