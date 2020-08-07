using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Combat
    {
        bool Winner = false;
        int Counter = 0;
        Player[] players = new Player[2];
        Stack<Critter>[] stacks = new Stack<Critter>[2];
        
        public Combat(Player player1, Player player2,List<Critter> crittersP1, List<Critter> crittersP2)
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

                int index = Counter % 2;
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
                        Console.WriteLine("Fue vencido el critter del jugador " + ((1 - index)+1));
                        if (players[1 - index].critters.Count == 0)
                        {
                            Winner = true;
                            Console.WriteLine("!!Hubo un ganador!!! y es el player : " + (index + 1));
                        }
                    }
                    Counter++;
                    index = Counter % 2;
                    Console.WriteLine("\nAhora es el turno del jugador: " + (index + 1));
                }
                else
                {
                    Console.WriteLine("El skill con ese número no existe, número fuera de rango");
                }
                
            }
        }
    }
}
