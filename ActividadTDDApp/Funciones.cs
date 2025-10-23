using System;
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

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (string.IsNullOrEmpty(contrasenya))
                return false;

            if (contrasenya.Length< 8)
                return false;

            if (!contrasenya.Contains('#'))
                return false;

            return true;
        }
    }
}
