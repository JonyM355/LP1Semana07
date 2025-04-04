using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        private byte Red { get; }
        private byte Green { get; }
        private byte Blue { get; }
        private byte Alpha { get; }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public byte GetGrey()
        {
            return (byte)((Red + Blue + Green) / 3);
        }

        public override string ToString()
        {
            return $"RGBA({Red}, {Green}, {Blue}, {Alpha})";
        }
    }
}