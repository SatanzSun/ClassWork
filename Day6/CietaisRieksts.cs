using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day6
{
    class CietaisRieksts
    {
        public static int Factorial(int n)
        {
            return n  > 0 ? n * Factorial(n - 1) : 1;
        }
    }
}
