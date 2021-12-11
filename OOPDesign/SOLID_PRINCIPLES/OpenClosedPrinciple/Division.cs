using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.OpenClosedPrinciple
{
    public class Division : IOperation
    {
        public int Operator(int a, int b, string s)
        {
            if (s == "/") return a / b;
            return -1;
        }
    }
}
