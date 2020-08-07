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
            if(Math.Abs(enemyCritter.bonusSpeed) < GetMaxBonus(enemyCritter))
            {
                Console.WriteLine("speed Down");
                enemyCritter.bonusSpeed += (int)(enemyCritter.BaseSpeed * porcentaje);
            }
            else
            {
                Console.WriteLine("Can't use a supportive skill of the same type more than three times on the same critter, you lose your turn!");
            }
        }

        public override float GetMaxBonus(Critter critter)
        {
            return Math.Abs(porcentaje*critter.BaseSpeed*maxUses);
        }

        public SpDwn(string name, int power, Affinity affinity, float porcentaje, int maxCounter) : base(name, power, affinity, porcentaje, maxCounter)
        {
        }
    }
}
