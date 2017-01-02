using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresExample
{
    public abstract class NodeAbstract<T>
    {
        public NodeAbstract<T> Next
        {
            get; set;
        }

        public T Value { get; set; }

        public NodeAbstract(){}

        public NodeAbstract(T item)
        {
            Value = item;
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
