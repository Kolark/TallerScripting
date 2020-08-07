using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Combate
    {
        bool Winner = false;
        int contador = 0;
        Player[] players = new Player[2];
        Stack<Critter>[] stacks = new Stack<Critter>[2];
        

        public void Turn(int skill)
        {
            if (!Winner)
            {

                int index = contador % 2;
                Console.WriteLine("Es turno del jugador: " + index +1);
                stacks[index].Peek().MoveSet[skill].DoSkill(stacks[index].Peek(), stacks[1 - index].Peek());
                if (stacks[1 - index].Peek().Hp <= 0)
                {
                    Critter exchange = stacks[1 - index].Pop();
                    players[index].critters.Add(exchange);
                    players[1 - index].critters.Remove(exchange);
                    if (players[1 - index].critters.Count == 0)
                    {
                        Winner = true;
                    }
                }
                contador++;
            }
        }

        public void PRINT()
        {
            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine("|----------" + i +"----------|");

            }
            
        }
    }
}
