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
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            { 
                return -1;
            }

            return n * CalcularFactorial(n - 1);    
        }
    }
}
