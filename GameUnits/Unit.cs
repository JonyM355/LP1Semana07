namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public int Move()
        {
            return movement;
        }

        public abstract float Cost{ get; }
        public override string ToString()
        {
            return $"{GetType().Name}: Hp = {Health}" +
            $" Cost = {Cost.ToString("0.00")}";
        }
    }
}
