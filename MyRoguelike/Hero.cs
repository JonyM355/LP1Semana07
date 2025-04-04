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
                xp += value;
                if (value > xp)
                {
                    xp = value;
                }
            }
        }

        public int Level => 1 + XP / 1000;

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

        public float MaxHealth => (float)100 + (Level - 1) * 20;

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