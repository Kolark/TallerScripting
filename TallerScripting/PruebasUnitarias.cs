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

            AttackSkill attackSkill = new AttackSkill("AtaqueFeróz", 0, Affinity.Wind);
            Console.WriteLine($"The power of the attack skill is: {attackSkill.Power}");

            SupportSkill atkUp = new AtkUp("AumentoDaño", 15, Affinity.Dark, 0.2f, 3);
            SupportSkill dfUp = new DefUp("AumentoDefensa", 15, Affinity.Dark, 0.2f, 3);
            SupportSkill spdDwn = new SpDwn("DisminucionVelocida", 15, Affinity.Dark, 0.2f, 3);
            Console.WriteLine($"The power of the dfUp skill is: {dfUp.Power}");
            Console.WriteLine($"The power of the atkUp skill is: {atkUp.Power}");
            Console.WriteLine($"The power of the spdDwn skill is: {spdDwn.Power}");

            List<Skill> skillSetTierra = new List<Skill> { attackSkill, spdDwn };
            List<Skill> skillSetAgua = new List<Skill> { attackSkill, spdDwn };
            List<Skill> skillSetLuz = new List<Skill> { atkUp, spdDwn };
            List<Skill> skillSetOscuridad = new List<Skill> { attackSkill, spdDwn };

            Critter tierra = new Critter("DragonsitoTierra", 50, 50, 10, 200, Affinity.Earth, skillSetTierra);
            Critter luz = new Critter("DragonsitoLuz", 40, 40, 5, 150, Affinity.Light, skillSetLuz);
            Critter agua = new Critter("DragonsitoAgua", 60, 60, 50, 100, Affinity.Water, skillSetAgua);
            Critter oscuridad = new Critter("DragonsitoOscuridad", 70, 70, 30, 300, Affinity.Dark, skillSetOscuridad);

            List<Critter> critersEsclavos1 = new List<Critter> { tierra, luz };
            List<Critter> critersEsclavos2 = new List<Critter> { oscuridad, agua };

            Player player1 = new Player(critersEsclavos1);
            Player player2 = new Player(critersEsclavos2);

            Combate combate = new Combate(player1, player2, player1.critters, player2.critters);
            combate.Turn(1);
            combate.Turn(1);
            combate.Turn(1);
            combate.Turn(1);
            combate.Turn(1);
            combate.Turn(1);
            combate.Turn(1);


        }
    }
}
