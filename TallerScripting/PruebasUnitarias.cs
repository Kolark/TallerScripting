using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class PruebasUnitarias
    {
        //PRUEBAS 1-2
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("=============PRUEBA1=================");
            AttackSkill attackSkill = new AttackSkill("AtaqueFeróz", 0, Affinity.Fire); //PRUEBA 1
            Console.WriteLine($"The power of the attackSkill skill is: {attackSkill.Power}");
            Console.WriteLine("=============PRUEBA2=================");
            SupportSkill atkUp = new AtkUp("AumentoDaño", 15, Affinity.Fire, 0.2f, 3); //PRUEBA 2
            Console.WriteLine($"The power of the atkUp skill is: {atkUp.Power}");
        }
        */


        //Prueba 3-4
        /*
        static void Main(string[] args)
        {
           SupportSkill dfUp = new DefUp("AumentoDefensa", 15, Affinity.Dark, 0.2f, 3);
           SupportSkill spdDwn = new SpDwn("DisminucionVelocida", 15, Affinity.Dark, -0.3f, 3);

           List<Skill> skillSetAgua = new List<Skill> {spdDwn};
           List<Skill> skillSetTierra = new List<Skill> { dfUp};

            Critter agua = new Critter("DragonsitoAgua", 60, 60, 50, 100, Affinity.Water, skillSetAgua);
            Critter tierra = new Critter("DragonsitoTierra", 50, 50, 10, 200, Affinity.Earth, skillSetTierra);

            List<Critter> critersEsclavos1 = new List<Critter> { agua };
            List <Critter> critersEsclavos2 = new List<Critter> { tierra};
            

            Player player1 = new Player(critersEsclavos1);
            Player player2 = new Player(critersEsclavos2);

            Combat combat = new Combat(player1, player2, player1.critters, player2.critters);

            Console.WriteLine("=============================================================== PRUEBA UNITARIA 3");
            combat.Turn(0);//1 spdown
            Console.WriteLine( "Speed Base: " + tierra.BaseSpeed);
            Console.WriteLine("Speed: " + tierra.Speed);

            Console.WriteLine("=============================================================== PRUEBA UNITARIA 4");

            Console.WriteLine("Defensa bonus : " + tierra.bonusDefense);
            Console.WriteLine("Maxima defensa posible : " +  dfUp.GetMaxBonus(tierra));
            combat.Turn(0);//2 defUp
            combat.Turn(0);//1 spdown
            combat.Turn(0);//2 defUp
            combat.Turn(0);//1 spdown
            combat.Turn(0);//2 defUp
            combat.Turn(0);//1  spdown
            combat.Turn(0);//2 defUp Utiliza por cuarta vez defensa y no se le permite, pierde el turno
            Console.WriteLine("Luego de aplicar dfUp 4 veces");

            Console.WriteLine("Defensa bonus : " + tierra.bonusDefense);
            
        }
        */
        //PRUEBA 5

        /*
        static void Main(string[] args)
        {
            AttackSkill attackSkill = new AttackSkill("AtaqueFeróz", 5, Affinity.Fire);
            SupportSkill dfUp = new DefUp("AumentoDefensa", 15, Affinity.Dark, 0.2f, 3);

            List<Skill> skillSetLuz = new List<Skill> { attackSkill };
            List<Skill> skillSetEarth = new List<Skill> { dfUp };
            

            Critter luz = new Critter("DragonsitoLuz", 40, 40, 5, 150, Affinity.Light, skillSetLuz);
            Critter tierra = new Critter("DragonsitoTierra", 50, 50, 10, 200, Affinity.Earth, skillSetEarth);

            List<Critter> critersEsclavos1 = new List<Critter> { luz };
            List<Critter> critersEsclavos2 = new List<Critter> { tierra };

            Player player1 = new Player(critersEsclavos1);
            Player player2 = new Player(critersEsclavos2);

            Combat combat = new Combat(player1, player2, player1.critters, player2.critters);

            Console.WriteLine("Vida Inicial Critter tierra: " + tierra.Hp);
            combat.Turn(0);
            Console.WriteLine("Vida luego del ataque con afinidad Fire: " + tierra.Hp);

        } 
        */

        //PRUEBA 6-7

        /*
        static void Main(string[] args)
        {
            AttackSkill attackSkill = new AttackSkill("AtaqueFeróz", 5, Affinity.Water);
            SupportSkill dfUp = new DefUp("AumentoDefensa", 15, Affinity.Dark, 0.2f, 3);

            List<Skill> skillSetWater = new List<Skill> { attackSkill };
            List<Skill> skillSetEarth = new List<Skill> { dfUp };


            Critter water = new Critter("DragonsitoWATER", 40, 40, 5, 150, Affinity.Light, skillSetWater);
            Critter Wind = new Critter("DragonsitoWIND", 50, 50, 10, 200, Affinity.Wind, skillSetEarth);
            Critter Dark = new Critter("DragonsitoDark", 60, 60, 50, 100, Affinity.Dark, skillSetEarth);
            Critter Fire = new Critter("DragonsitoOscuridad", 70, 70, 30, 300, Affinity.Fire, skillSetWater);

            List<Critter> critersEsclavos1 = new List<Critter> {Dark,water };
            List<Critter> critersEsclavos2 = new List<Critter> {Fire, Wind };

            Player player1 = new Player(critersEsclavos1);
            Player player2 = new Player(critersEsclavos2);

            Combat combate = new Combat(player1, player2, player1.critters, player2.critters);
            Console.WriteLine("============================PRUEBA 6");
            
            Console.WriteLine("Vida Inicial Critter tierra: " + Wind.Hp);
            combate.Turn(0); //1
            Console.WriteLine("Vida luego del ataque con afinidad water: " + Wind.Hp);
            Console.WriteLine("============================PRUEBA 7");
            combate.Turn(0); //2
            combate.Turn(0); //1
            combate.Turn(0); //2
            combate.Turn(0); //1 

            Console.WriteLine("=====================Critters Player 1");
            foreach (Critter i in player1.critters)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine("=====================Critters Player 2");
            foreach (Critter i in player2.critters)
            {
                Console.WriteLine(i.Name);
            }

        }
        */


        
    }
}
