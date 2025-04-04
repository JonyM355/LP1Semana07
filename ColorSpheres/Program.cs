using System;
using System.Security.Cryptography;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //create colors
            Color red = new Color(255,0,0, 50);
            Color green = new Color(255,0,0);
            Color blue = new Color(255,0,0);
            Color yellow = new Color(0,255,255, 200);
            Color grey = new Color(180,230,255);
            grey.GetGrey();

            //create spheres
            Sphere s1 = new Sphere(red, 10);
            Sphere s2 = new Sphere(green, 10);
            Sphere s3 = new Sphere(blue, 10);
            Sphere s4 = new Sphere(yellow, 10);
            Sphere s5 = new Sphere(grey, 10);

            //Sphere methods
            s1.Pop();
            s1.Throw();
            s1.GetTimesThrown();
            Console.WriteLine($"Esfera 1:");
            Console.WriteLine($"Color: {s1.GetColor()}");
            Console.WriteLine($"Times throwned: {s1.GetTimesThrown()}");
            Console.WriteLine($"Popped: {s1.IsPopped()}\n");


            s2.Throw();
            s2.Throw();
            s2.Throw();
            s2.GetTimesThrown();
            Console.WriteLine($"Esfera 2:");
            Console.WriteLine($"Color: {s2.GetColor()}");
            Console.WriteLine($"Times throwned: {s2.GetTimesThrown()}");
            Console.WriteLine($"Popped: {s2.IsPopped()}\n");


            s3.Throw();
            s3.Pop();
            s3.Throw();
            s3.GetTimesThrown();
            Console.WriteLine($"Esfera 3:");
            Console.WriteLine($"Color: {s3.GetColor()}");
            Console.WriteLine($"Times throwned: {s3.GetTimesThrown()}");
            Console.WriteLine($"Popped: {s3.IsPopped()}\n");

            s4.Pop();
            s4.Throw();
            s4.Throw();
            s4.GetTimesThrown();
            Console.WriteLine($"Esfera 4:");
            Console.WriteLine($"Color: {s4.GetColor()}");
            Console.WriteLine($"Times throwned: {s4.GetTimesThrown()}");
            Console.WriteLine($"Popped: {s4.IsPopped()}\n");

            s5.Throw();
            s5.Throw();
            s5.Throw();
            s5.Throw();
            s5.Throw();
            s5.GetTimesThrown();
            Console.WriteLine($"Esfera 5:");
            Console.WriteLine($"Color: {s5.GetColor().GetGrey()}");
            Console.WriteLine($"Times throwned: {s5.GetTimesThrown()}");
            Console.WriteLine($"Popped: {s5.IsPopped()}\n");


        }
    }
}
