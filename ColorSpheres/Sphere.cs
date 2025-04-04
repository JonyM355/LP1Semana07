using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private float radius;
        private int times_thrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            times_thrown = 0;
        }

        public void Pop() => radius = 0;

        public int Throw()
        {
            if (radius > 0) 
            {
                times_thrown++;
            }

            return times_thrown;
        }

        public int GetTimesThrown() => times_thrown;

        public Color GetColor() => color;

        public bool IsPopped() => radius == 0;
    }
}