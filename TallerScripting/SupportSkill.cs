using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class SupportSkill : Skill
    {
        private float porcentaje;
        private int valor;
        public SupportSkill(string name, int power, Affinity affinity,float porcentaje) : base(name, power, affinity)
        {
            this.porcentaje = porcentaje;
        }

        public float Porcentaje { get => porcentaje;}
        public int Valor { get => valor;}

        public override void DoSkill()
        {
            
        }
    }
}
