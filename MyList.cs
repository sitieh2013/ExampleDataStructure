using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public class MyList<T>
    {
        private ManagerNodeAbstract<T> myCollection;

        public MyList()
        {
            myCollection = new ManagerNodeSimple<T>();
        }

        public MyList(ManagerNodeAbstract<T> collection)
        {
            myCollection = collection;
        }

        public T this[int index]
        {
            get
            {
                return myCollection.FindNode(index).Value;
            }

            set
            {
                myCollection.FindNode(index).Value = value;
            }
        }

        public int Count
        {
            get
            {
                return myCollection.CountNode;
            }
        }

        public void Add(T item)
        {
            myCollection.AddNode(item);
        }

        public void Clear()
        {
            myCollection.ClearNode();
        }

        public void Insert(int index, T item)
        {
            myCollection.InsertNode(index, item);
        }

        public void RemoveAt(int index)
        {
            myCollection.RemoveAtNode(index);
        }
    }
}
