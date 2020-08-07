﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    
    class AttackSkill : Skill
    {
        Random rnd = new Random();
        public AttackSkill(string name, int power, Affinity affinity) : base(name, power, affinity) 
        {
            this.power = rnd.Next(1, 11);
        }

        public override void DoSkill(Critter currentCritter, Critter enemyCritter)
        {
            
        }

    }
}
