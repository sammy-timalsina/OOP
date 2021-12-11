using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.InterfaceSegration
{
    public class Square :I2DShape
    {
        //There is a problem on the OOP desing here
        //it violates the SOLID principle
        //Square does not require calculate volume method
        public double calculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
