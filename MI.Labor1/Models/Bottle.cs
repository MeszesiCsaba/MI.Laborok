using System;

namespace MI.Labor1.Models
{
    public class Bottle
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public double Capacity { get; set; }
        public double CurrentVolume { get; set; }
    
    public Bottle(string name, string material, double capacity, double currentVolume)
        {
            Name = name;
            Material = material;
            Capacity = capacity;
            CurrentVolume = currentVolume;
        }

    public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Current Volume: " + CurrentVolume);
        }
    }
}