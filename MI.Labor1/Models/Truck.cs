using System;
using System.Collections.Generic;
using System.Text;

namespace MI.Labor1.Models
{
    public class Truck
    {
        public double Capacity { get; set; }
        public double usedCapacity = 0;

        public Truck(double capacity)
        {
            Capacity = capacity;
        }

        public void AddBottle(Bottle bottle)
        {
            if (usedCapacity + bottle.Capacity <= Capacity)
            {
                usedCapacity += bottle.Capacity;

                Console.WriteLine(bottle.Name + " felvettük a kamionba.");
                Console.WriteLine("Foglalt kapacitás: " + usedCapacity + " / " + Capacity);
            }
            else
            {
                Console.WriteLine(bottle.Name + " nem fér el a kamionban. Kapacitás: ");
            }
        }
    }
}
