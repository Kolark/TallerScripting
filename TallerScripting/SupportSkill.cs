using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    enum Habilidad
    {
        atkUp, DefUp, SpeedDown
    }
    class SupportSkill : Skill
    { 
        
        private float porcentaje;
        private int valor;
        int habilidadSoporte = 0;
        Habilidad habilidad;
        public SupportSkill(string name, int power, Affinity affinity,float porcentaje, Habilidad habilidad) : base(name, power, affinity)
        {
            this.porcentaje = porcentaje;
            this.habilidad = habilidad;
        }

        public float Porcentaje { get => porcentaje;}
        public int Valor { get => valor;}

        public override void DoSkill(Critter critter)
        {

        }


    }
}
