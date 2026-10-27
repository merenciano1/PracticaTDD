using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTDD
{
    public class Funciones //JoMeRu2627
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 1;

            long factorial = 1;
            for (int i = 2; i <= n; i++) factorial *= i;

            return factorial;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if(contrasenya == null)
            {
                return false;
            }

            if(contrasenya.Length < 8)
            {
                return false;
            }

            if(contrasenya == "")
            {
                return false;
            }

            if(!contrasenya.Contains("#"))
            {
                return false;
            }
            return true;
        }
    }
}
