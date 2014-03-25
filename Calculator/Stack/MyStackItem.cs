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
