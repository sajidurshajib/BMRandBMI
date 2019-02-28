using System;
namespace BMRandBMI
{
    public class anotherPlanet
    {
        public anotherPlanet(){
            Console.WriteLine("\n\tPlanet\t\tPlanet Code");
            Console.WriteLine("\t---------------------------");
            Console.WriteLine("\tMercury\t\t0.38");
            Console.WriteLine("\tVenus\t\t0.91");
            Console.WriteLine("\tEarth\t\t1");
            Console.WriteLine("\tMars\t\t0.38");
            Console.WriteLine("\tJupiter\t\t2.34");
            Console.WriteLine("\tSaturn\t\t0.93");
            Console.WriteLine("\tUranus\t\t0.92");
            Console.WriteLine("\tNeptune\t\t1.12");
        }
        public double alienWeight(double yourWeight, double surfaceCode){
            double alienWeight=0;
            alienWeight = yourWeight * surfaceCode;
            return alienWeight;
        }
    }
}