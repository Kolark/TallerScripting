﻿using System;
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
        private float hp;

        public float bonusAttack;
        public float bonusDefense;
        public float bonusSpeed;

        private List<Skill> moveSet;
        Affinity affinity;



        
        public Critter(string name, int baseAttack, int baseDefense, int baseSpeed, float hp, Affinity affinity, List<Skill> skills)
        {
            this.name = name;
            this.baseAttack = baseAttack;
            this.baseDefense = baseDefense;
            this.baseSpeed = baseSpeed;
            this.hp = hp;
            this.affinity = affinity;
            moveSet = skills;
        }

        public void GetDamage(float damageTaken)
        {
            hp -= damageTaken;
            if (hp < 0) hp = 0;
        }

        public string Name { get => name;}
        public float BaseAttack { get => baseAttack + bonusAttack;}
        public float BaseDefense { get => baseDefense + bonusDefense;}
        public float BaseSpeed { get => baseSpeed + bonusSpeed;}
        public float Hp { get => hp;}
        public Affinity Affinity { get => affinity;}
        public List<Skill> MoveSet { get => moveSet;}
    }
}
