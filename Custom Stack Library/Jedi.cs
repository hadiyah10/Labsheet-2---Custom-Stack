using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack_Library
{
    public class Jedi : IIntern
    {
        private string Name;
        private int id;
        public string NameId => $"Jedi - {Name}: {id}";   

        public Jedi(string name, int id)
        {
            Name = name;
            this.id = id;
        }    
    }
}
