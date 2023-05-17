using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class ConversorDeMoeda
    {
        public static double IoF = 6.0;

        public static double DolarEmReais(double cot, double quantia)
        {
            double total = quantia * cot;
            return total + total * IoF / 100;
        }
    }
}
