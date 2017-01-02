using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public abstract class ManagerNodeAbstract<T>
    {
        public NodeAbstract<T> root
        {
            get; set;
        }
        public NodeAbstract<T> finish
        {
            get; set;
        }

        public int CountNode
        {
            get; set;
        }

        public virtual void ClearNode()
        {
            root = null;
            CountNode = 0;
        }

        public virtual NodeAbstract<T> FindNode(int index)
        {
            int position = 0;
            NodeAbstract<T> temp = root;

            while (position < index)
            {
                temp = temp.Next;
                position++;
            }

            return temp;
        }

        public virtual void RemoveAtNode(int index)
        {
            if (index == 0)
            {
                root = CountNode == 1 ? null : root.Next;
            }
            else
            {
                NodeAbstract<T> temp = FindNode(index - 1);
                temp.Next = temp.Next.Next;
            }

            CountNode--;
        }

        public abstract void AddNode(T item);

        public abstract void InsertNode(int index, T item);        
    }
}
