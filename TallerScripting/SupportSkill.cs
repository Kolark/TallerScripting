using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    abstract class SupportSkill : Skill
    {

        protected float percentage;
        protected int counter = 0;
        protected int maxUses;


        public SupportSkill(string name, int power, Affinity affinity, float porcentaje, int maxUses) : base(name, power, affinity)
        {
            this.percentage = porcentaje;
            this.power = 0;
            this.maxUses = maxUses;
        }

        public float Porcentaje { get => percentage; }

        public abstract float GetMaxBonus(Critter critter);

    }
}
