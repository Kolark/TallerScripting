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
            if (currentCritter.bonusAttack < GetMaxBonus(currentCritter))
            {
                Console.WriteLine("attack Up");
                currentCritter.bonusAttack += (int)(currentCritter.BaseAttack * porcentaje);
            }
            else
            {
                Console.WriteLine("Can't use a AtkUp skill of the same type more than three times in the same critter, you lose your turn!");
            }
        }

        public override float GetMaxBonus(Critter critter)
        {
            return Math.Abs(porcentaje * critter.BaseAttack * maxUses);
        }

        public AtkUp(string name, int power, Affinity affinity, float porcentaje, int maxCounter) : base(name, power, affinity, porcentaje, maxCounter)
        {
        }
    }

    
}
