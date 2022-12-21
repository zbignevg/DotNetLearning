using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_OOP_Interfaces
{
    //Create an interface named IVehicle with methods Drive and Refuel (you can choose the return type yourself and how you will implement it,
    //you can also do it with void)

    //Then create a class Car that will implement this interface and also have properties string Model and int Fuel.

    //Implement the necessary methods, the Drive() method must check whether the fuel has not run out, if not, it is possible to drive.

    //The Refuel method must check whether the amount to be refilled is not minuscule (you can also make the maximum size of the fuel tank,
    //but think about how you will reuse that functionality)
    abstract class Car : IVehicle
    {
        public string model { get; set; }
        public int fuel { get; set; }
        public bool canDrive { get; set; }
        private const int _minFuel = 5;
        private const int _maxFuel = 80;

        public Car(string brand) {
            this.model = brand;
            this.fuel = 0;
            this.canDrive = false;
        }

        public void Drive()
        {
            if (this.fuel > _minFuel)
                this.canDrive = true;
            else
                this.canDrive = false;
        }

        public void Refuel(int amount)
        {
            if (amount <= _maxFuel - this.fuel)
            {
                this.fuel += amount;
            } else
            {
                Console.WriteLine("Enough fuel, refuel not necessary");
            }
            this.Drive();
        }
    }
}
