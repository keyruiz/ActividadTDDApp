﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static long CalcularFactorial(int numero)
        {
            if (numero == 0)
                return 1;
            if (numero < 0)
                return -1;
            long result = 1;
            for (long i = 1; i <= numero; i++)
            { 
                result *= i;
            }
            return result;
        }
    }
}
