using System;

namespace BetterColorSpheres
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
            Sphere s2 = new Sphere(green, 5);
            Sphere s3 = new Sphere(blue, 3);
            Sphere s4 = new Sphere(yellow, 50);
            Sphere s5 = new Sphere(grey, 197);

            //Sphere methods
            s1.Pop();
            s1.Throw();
            Console.WriteLine($"Esfera 1:");
            Console.WriteLine($"Color: {s1.Color}");
            Console.WriteLine($"Times throwned: {s1.Times_thrown}");
            Console.WriteLine($"Popped: {s1.IsPopped()}\n");


            s2.Throw();
            s2.Throw();
            s2.Throw();
            Console.WriteLine($"Esfera 2:");
            Console.WriteLine($"Color: {s2.Color}");
            Console.WriteLine($"Times throwned: {s2.Times_thrown}");
            Console.WriteLine($"Popped: {s2.IsPopped()}\n");


            s3.Throw();
            s3.Pop();
            s3.Throw();
            Console.WriteLine($"Esfera 3:");
            Console.WriteLine($"Color: {s3.Color}");
            Console.WriteLine($"Times throwned: {s3.Times_thrown}");
            Console.WriteLine($"Popped: {s3.IsPopped()}\n");

            s4.Pop();
            s4.Throw();
            s4.Throw();
            Console.WriteLine($"Esfera 4:");
            Console.WriteLine($"Color: {s4.Color}");
            Console.WriteLine($"Times throwned: {s4.Times_thrown}");
            Console.WriteLine($"Popped: {s4.IsPopped()}\n");

            s5.Throw();
            s5.Throw();
            s5.Throw();
            s5.Throw();
            s5.Throw();
            Console.WriteLine($"Esfera 5:");
            Console.WriteLine($"Color: {s5.Color.GetGrey()}");
            Console.WriteLine($"Times throwned: {s5.Times_thrown}");
            Console.WriteLine($"Popped: {s5.IsPopped()}\n");
        }
    }
}
