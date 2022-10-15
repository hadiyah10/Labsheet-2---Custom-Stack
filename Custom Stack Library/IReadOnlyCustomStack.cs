using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack_Library
{
    public interface IReadOnlyCustomStack<T>
    {
        void Push(T item);
        int Count();
    }
}
