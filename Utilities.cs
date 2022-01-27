using System;

namespace c_sharp_generics
{
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value){
            var obj = new T();
        }
    }

}