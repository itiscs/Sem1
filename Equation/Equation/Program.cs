﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation e;

            e = Equation.CreateEquation();
            
            e.Solve();
            e.PrintSol();

        }
    }
}
