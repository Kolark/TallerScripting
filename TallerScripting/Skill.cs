using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    public abstract class Skill
    {
        protected string name;
        protected int power;
        protected Affinity affinity;

        public Skill(string name, int power, Affinity affinity)
        {
            this.name = name;
            this.power = power;
            this.affinity = affinity;
        }

        public string Name { get => name; }
        public int Power { get => power; }
        public Affinity Affinity { get => affinity; }

        public abstract void DoSkill();
        //public virtual void DoSkill(Critter critter) { }
        //public virtual void DoSkill(ref float Value) { }
    }
}
