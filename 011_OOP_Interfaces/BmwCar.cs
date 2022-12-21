using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _011_OOP_Interfaces
{
    //Modify the program for the first task.
    //Make the Car class abstract and add the property string Model.
    //Create a class BmwCar that inherits from the class Car and has its own property bool IsXDrive.
    //Create a class AudiCar that inherits from the class Car and has its own property bool IsQuattro.
    internal class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public BmwCar(string model): base(model)
        {}
    }
}
