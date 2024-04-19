using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            (units[0] as MilitaryUnit).Attack(units[1]);
            (units[0] as MilitaryUnit).Attack(units[2]);

            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }
        }
    }
}
