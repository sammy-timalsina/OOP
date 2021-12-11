using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Polymorphism
{
    public class AnimalService
    {
        public void Speak()
        {
            Animal dog = new Dog();
            dog.Speak();
            Animal cat = new Cat();
            cat.Speak();
        }
    }
}
