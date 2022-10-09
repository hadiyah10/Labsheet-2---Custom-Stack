using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack_Library
{
    internal class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(//ICustomStack<Jedi> stackJedi
                                                       ICustomStack<IIntern> stackJedi)
        {
            while (stackJedi.Count() > 0)
            {
                Console.WriteLine(stackJedi.Pop().NameId); 
            }
        }
    }
}
