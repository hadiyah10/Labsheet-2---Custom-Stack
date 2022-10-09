using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack_Library
{
    public class CustomStack<T>: ICustomStack <T> where T : IIntern 
    {
        T[] arr;
        const int max = 10;
        int count;

        public CustomStack()
        {
            arr = new T[max];
            count = 0;
        }
        public void Push(T value) => arr[count++] = value;
        public T Pop() => arr[--count]; 
        public int Count() => count;

    }
}
