using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principies
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started");
        }
    }

    public class ElectricCar : Car
    {
        
    }

    // Comment: Liskov prinsipi odur ki derived klass ozunu base klassin obyekti kimi apara bilir

}
