using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Stack
{
    public class MyStackItem<T>
    {
        public MyStackItem(T obj)
        {
            Object = obj;
        }

        public T Object
        {
            get;
            set;
        }

        public MyStackItem<T> Next
        {
            get;
            set;
        }

        public MyStackItem<T> Previous
        {
            get;
            set;
        }
    }
}
