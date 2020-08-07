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
        
        public Combate(Player player1, Player player2,List<Critter> crittersP1, List<Critter> crittersP2)
        {
            players[0] = player1;
            players[1] = player2;
            stacks[0] = new Stack<Critter>(crittersP1);
            stacks[1] = new Stack<Critter>(crittersP2);
        }

        public void Turn(int skill)
        {
            
            if (!Winner)
            {

                int index = contador % 2;
                Console.WriteLine("The player  " + (index + 1) + " did the following effect");
                    
                if(skill < stacks[index].Peek().MoveSet.Count)
                {
                    Console.WriteLine("critter: " + stacks[index].Peek().Name);
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
                    index = contador % 2;
                    Console.WriteLine("Ahora es el turno del jugador: " + (index + 1));
                }
                else
                {
                    Console.WriteLine("El skill con ese número no existe, número fuera de rango");
                }
                
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
