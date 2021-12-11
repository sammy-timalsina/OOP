using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.InterfaceSegration
{
    public class Cuboid : I3dShape,I2DShape
    {
        public double calculateArea()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// no problem here, it has both area and volume
        /// </summary>
        /// <returns></returns
        public double calculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
