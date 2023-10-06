using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_R_AZB.Clase
{
    internal class Secuencia
    {
        public void intervalo(int numero1, int numero2)
        {
            if (numero1 < numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    Console.WriteLine("La secuencia de los números es " + i);
                }

            }
            else if (numero1 > numero2)
            {
                for (int i = numero1; i >= numero2; i--)
                {
                    Console.WriteLine("La secuencia de los números es " + i);

                }

            }
            else
            {
                Console.WriteLine("Los numeros son iguales ", numero1, numero2);

            }

        }
    }
}        


