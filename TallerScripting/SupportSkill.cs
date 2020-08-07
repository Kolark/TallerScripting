using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    abstract class SupportSkill : Skill
    { 
        
        protected float porcentaje;
        protected int counter = 0;
        protected int maxUses;


        public SupportSkill(string name, int power, Affinity affinity,float porcentaje, int counter, int maxUses) : base(name, power, affinity)
        {
            this.porcentaje = porcentaje;
            this.power = 0;
            this.maxUses = maxUses;
        }

        public float Porcentaje { get => porcentaje;}


    }
}
