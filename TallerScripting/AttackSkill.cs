using System;
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
            if(this.power <= 0 && this.power > 10)
            {
                Console.WriteLine("Poder seleccionado invalido, se asignará un valor aleatorio entre 1 y 10");
                this.power = rnd.Next(1, 11);
            }
        }

        public override void DoSkill(Critter currentCritter, Critter enemyCritter)
        {
            float damageValue = (power + currentCritter.BaseAttack)  * Stats.Matriz[(int)(affinity),(int)(enemyCritter.Affinity)];
        }

    }
}
