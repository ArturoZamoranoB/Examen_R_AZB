using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_R_AZB.Clase
{
    internal class tabla
    {
        public void Tablasdemultiplicar(int n, int multiplicador)
        {
            if (multiplicador >= 10)
            {
                
                Console.WriteLine($" {n * multiplicador}");
                
                Tablasdemultiplicar(n, multiplicador + 1);
            }
            else
            {
                Console.WriteLine("fuera de los limites, 1 al 10");
            }
        }
    }
}

