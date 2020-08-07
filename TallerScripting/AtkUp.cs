using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class AtkUp : SupportSkill
    {
        public override void DoSkill(Critter currentCritter, Critter enemyCritter)
        {
            throw new NotImplementedException();
        }

        public AtkUp(string name, int power, Affinity affinity, float porcentaje) : base(name, power, affinity, porcentaje)
        {
        }
    }

    
}
