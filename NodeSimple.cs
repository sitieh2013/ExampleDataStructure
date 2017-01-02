using System;

namespace StructuresExample
{
    public class NodeSimple<T> : NodeAbstract<T>
    { 
        public static NodeAbstract<T> NewNode(T item)
        {
            NodeAbstract<T> Node = new NodeSimple<T>();
            Node.Value = item;
            return Node;
        }
    }
}