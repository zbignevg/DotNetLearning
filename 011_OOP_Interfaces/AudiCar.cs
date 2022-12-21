using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_OOP_Interfaces
{
    internal class AudiCar : Car
    {
        public bool isQuattro { get; set; }
        public AudiCar(string model) : base(model)
        {}
    }
}
