using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Skill
    {
        private string name;
        private int power;
        Affinity affinity;

        public Skill(string name, int power, Affinity affinity)
        {
            this.name = name;
            this.power = power;
            this.affinity = affinity;
        }

        public string Name { get => name;}
        public int Power { get => power;}
        public Affinity Affinity { get => affinity;}
    }
}
