using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.OpenClosedPrinciple
{
    public class Operations
    {
        //should be able to modify the class behaviour without modifying it
        //open for extension and closed for modification
        public void Calculators(int a, int b)
        {
            Addition add = new Addition();
            int x=add.Operator(2, 3,"+");
            Subtraction sub = new Subtraction();
            int y = sub.Operator(3, 4, "-");
        }
    }
}
