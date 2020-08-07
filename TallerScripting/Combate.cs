using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Combate
    {
        int contador = 0;
        Player[] players = new Player[2];
        Stack<Critter>[] stacks = new Stack<Critter>[2];
        

        public void Turn(int skill)
        {
            //stacks[contador % 2].Peek().MoveSet[skill].DoSkill();
        }
    }
}
