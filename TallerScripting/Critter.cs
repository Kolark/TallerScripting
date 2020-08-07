using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerScripting
{
    public class Critter
    {
        private string name;
        private int baseAttack;
        private int baseDefense;
        private int baseSpeed;
        private int hp;

        public int bonusAttack;
        public int bonusDefense;
        public int debuffSpeed;

        private List<Skill> moveSet;
        Affinity affinity;



        
        public Critter(string name, int baseAttack, int baseDefense, int baseSpeed, int hp, Affinity affinity, List<Skill> skills)
        {
            this.name = name;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpeed = baseSpeed;
            this.hp = hp;
            this.affinity = affinity;
            moveSet = skills;
        }

        public void GetDamage(Skill skill, Critter critter)
        {
            int damageTaken = (skill.Power + critter.baseAttack) /*  * AffinityMultiplier*/;
        }

        public string Name { get => name;}
        public int BaseAttack { get => baseAttack + bonusAttack;}
        public int BaseDefense { get => baseDefense + bonusDefense;}
        public int BaseSpeed { get => baseSpeed - debuffSpeed;}
        public int Hp { get => hp;}
        public Affinity Affinity { get => affinity;}
        public List<Skill> MoveSet { get => moveSet;}
    }
}
