using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Polymorphism
{
    public class Cat:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
