using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public float Radius { get; private set; }
        public int Times_thrown { get; private set; }

        public Sphere(Color color, float radius)
        {
            Color = color;
            Radius = radius;
            Times_thrown = 0;
        }

        public void Throw()
        {
            if (Radius > 0) 
            {
                Times_thrown++;
            }
        }

        public void Pop() => Radius = 0;

        public bool IsPopped() => Radius == 0;
    }
}