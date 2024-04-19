namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health
        {
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
        }

        public override float Cost
        {
            get
            { 
                return AttackPower + XP;
            }
        }

        public void Attack(Unit u)
        {
            XP += XP;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{GetType().Name}-" +
        $" Hp = {Health} Cost = {Cost.ToString("0.00")}";
        } 
    }
}
