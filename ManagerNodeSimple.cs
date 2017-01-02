using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public class ManagerNodeSimple<T> : ManagerNodeAbstract<T>
    {
        public override void AddNode(T item)
        {
            NodeAbstract<T> nodeNew = NodeSimple<T>.NewNode(item);
            
            if (root == null)
                root = nodeNew;
            else
                finish.Next = nodeNew;

            finish = nodeNew;
            CountNode++;
        }
        
        public override void InsertNode(int index, T item)
        {
            NodeAbstract<T> nodeNew = NodeSimple<T>.NewNode(item);

            if (index == 0)
            {   
                nodeNew.Next = root;
                root = nodeNew;
            }
            else
            {
                NodeAbstract<T> temp = FindNode(index - 1);
                nodeNew.Next = temp.Next;
                temp.Next = nodeNew;
            }

            CountNode++;
        }
    }
}
