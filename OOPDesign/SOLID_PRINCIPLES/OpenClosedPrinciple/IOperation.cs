﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.SOLID_PRINCIPLES.OpenClosedPrinciple
{
     interface IOperation
    {
       int  Operator(int a, int b, string s);
    }
}