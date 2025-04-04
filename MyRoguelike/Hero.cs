using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;

        public string Name { get; }

        public int XP
        {
            get => xp;

            set
            {
                xp = value;
            }
        }
        public int Level => XP / 100;
        
        public float Health
        {
            get
            {
                if (health < 0)
                {
                    return 0;
                }
                if (health > MaxHealth)
                {
                    return MaxHealth;
                }
                return health;
            }
            set
            {
                health = value;
            }
        }

        public float MaxHealth
        {
            get
            {
                return (float)100 + (Level - 1) * 20;
            }
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;

            XP = (int)damage / 20;
        }


        public Hero(string name)
        {
            Name = name;
            xp = 0;
            Health = MaxHealth;
        }
    }
}