using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class SpDwn : SupportSkill
    {
        public override void DoSkill(Critter currentCritter, Critter enemyCritter)
        {
            if (counter > this.maxUses) Console.WriteLine("Can't use a supportive skill of the same type more than three times, you lost your turn!");
            else
            {
                Console.WriteLine("Se disminutó la velocidad");
                enemyCritter.bonusSpeed += (int)(enemyCritter.BaseSpeed * porcentaje);
                counter++;
            }
        }

        public SpDwn(string name, int power, Affinity affinity, float porcentaje, int maxCounter) : base(name, power, affinity, porcentaje, maxCounter)
        {
        }
    }
}
