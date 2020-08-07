using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class AttackSkill : Skill
    {
        public AttackSkill(string name, int power, Affinity affinity) : base(name, power, affinity) {}

        public override void DoSkill(Critter critter)
        {
            
        }
    }
}
