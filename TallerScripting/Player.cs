using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Player
    {
        public List<Critter> critters;

        public Player(List<Critter> critters)
        {
            this.critters = critters;
        }
    }
}
