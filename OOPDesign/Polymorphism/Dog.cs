using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Polymorphism
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
