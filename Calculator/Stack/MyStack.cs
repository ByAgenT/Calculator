using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Stack
{
    public class MyStack<T>
    {
        public MyStackItem<T> Top
        {
            get;
            set;
        }

        public void Push(T obj)
        {
            MyStackItem<T> item = new MyStackItem<T>(obj);
            if (Top != null)
            {
                item.Previous = Top;
                Top.Next = item;
                Top = Top.Next;
            }
            if (Top == null)
            {
                Top = item;
            }
        }

        public T Pop()
        {
            if (Top == null)
            {
                return default(T);
            }
            T obj = Top.Object;
            Top = Top.Previous;
            if (Top != null)
            {
                Top.Next = null;
            }
            return obj;
        }

    }
}
