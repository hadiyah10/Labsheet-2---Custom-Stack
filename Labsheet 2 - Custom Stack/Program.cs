using Custom_Stack_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_2___Custom_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            stack.Push("Jedi-x");
            stack.Pop();
            stack.Push("Jedi");
            stack.Push("SkillsLab");
            //stack.Push(100);

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();

            //stack of type Jedi
            CustomStack<Jedi> stackJedi = new CustomStack<Jedi>();  
            stackJedi.Push(new Jedi("new1", 1));
            stackJedi.Push(new Jedi("new2", 2));
            stackJedi.Push(new Jedi("new3", 3));     
        }
    }
}
