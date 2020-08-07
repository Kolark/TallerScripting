using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class PruebasUnitarias
    {
        static void Main(string[] args)
        {

            AttackSkill attackSkill = new AttackSkill("AtaqueFeróz", 15, Affinity.Wind);
            Console.WriteLine(attackSkill.Power);

        }
    }
}
