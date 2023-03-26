using System;
using Prototype;
namespace Prototype
{
    class Program
    {
        static void Main()
        {
            Transport ship;
            ship = new Ship("Titanic", 1866, 28, new Engine("Some engine", "Diesel", 673), "Mail");
            Transport vehicle1 = ship.Clone();
            Console.WriteLine(vehicle1);
            
            Console.WriteLine("\n_______________________________\n");

            Transport truck;
            truck = new Truck("Tatra 815", 1976, 120, new Engine("T3-930-53", "Diesel", 19), "ckeieuec");
            Transport vehicle2 = truck.Clone();
            Console.WriteLine(vehicle2);

            Console.WriteLine("\n________________________________\n");

            Transport plane;
            plane = new Plane("Boeing 777", 2004, 905, new Engine("General Electric 90", "Avgas", 53457), 15000);
            Transport vehicle3 = plane.Clone();
            Console.WriteLine(vehicle3);
        }
    }
}
