using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack_Library
{
    internal class SkillsLab : IIntern
    {
        private string Name;
        private int id;
        public string NameId => $"SkillsLab - {Name}: {id}";

        public SkillsLab(string name, int id)
        {
            Name = name;
            this.id = id;
        }
    }
}
