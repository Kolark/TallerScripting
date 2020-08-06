using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    class Critter
    {
        private string name;
        private int baseAttack;
        private int baseDefense;
        private int baseSpeed;
        private int hp;
        Affinity affinity;


        
        public Critter(string name, int baseAttack, int baseDefense, int baseSpeed, int hp, Affinity affinity)
        {
            this.name = name;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpeed = baseSpeed;
            this.hp = hp;
            this.affinity = affinity;
        }

        public string Name { get => name;}
        public int BaseAttack { get => baseAttack;}
        public int BaseDefense { get => baseDefense;}
        public int BaseSpeed { get => baseSpeed;}
        public int Hp { get => hp;}
        public Affinity Affinity { get => affinity;}
    }
}
