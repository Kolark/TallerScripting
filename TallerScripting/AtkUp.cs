﻿using System;
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
            if (counter > this.maxUses) Console.WriteLine("Can't use a supportive skill of the same type more than three times, you lost your turn!");
            else
            {
                currentCritter.bonusAttack += (int)(currentCritter.BaseAttack * porcentaje);
            }   
        }

        public AtkUp(string name, int power, Affinity affinity, float porcentaje, int counter, int maxCounter) : base(name, power, affinity, porcentaje, counter, maxCounter)
        {
        }
    }

    
}