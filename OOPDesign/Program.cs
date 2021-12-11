using OOPDesign.Encapsulation;
using OOPDesign.Inheritance;
using OOPDesign.Polymorphism;
using System;

namespace OOPDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation example
            //User u = new User();
            //u.Age = 88;
            //u.Name = "Pupua";
            //Inheritance
            //Car car = new Car();
            //car.fuelAmount = 20;
            //car.capacity = 99;
            //car.ApplyBrakes();
            //car.NoOfWheels();
            //
            //Polymorphism
            //
            AnimalService ser = new AnimalService();
            ser.Speak();
            Console.WriteLine("Hello World!");
        }
    }
}
