using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class DefUp : SupportSkill
    {
        public override void DoSkill(Critter currentCritter, Critter enemyCritter)
        {
            if (currentCritter.bonusDefense < GetMaxBonus(currentCritter))
            {
                Console.WriteLine("defense Up");
                currentCritter.bonusDefense += (int)(currentCritter.BaseDefense * porcentaje);
            }
            else
            {
                Console.WriteLine("Can't use a supportive skill of the same type more than three times in the same critter, you lose your turn!");
            }
        }

        public override float GetMaxBonus(Critter critter)
        {
            return Math.Abs(porcentaje * critter.BaseDefense * maxUses);
        }

        public DefUp(string name, int power, Affinity affinity, float porcentaje, int maxCounter) : base(name, power, affinity, porcentaje, maxCounter)
        {
        }
    }
}
