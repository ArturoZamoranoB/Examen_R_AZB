using Examen_R_AZB.Clase;

namespace Examen_R_AZB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secuencia Secuencia1 = new Secuencia();

            Console.WriteLine("ingrese un numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese un numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Secuencia1.intervalo(numero1, numero2);

            
            
            
            
            tabla tabla10= new tabla();

            Console.Write("Ingrese un número para su tabla de multiplicar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar del número: ");
            tabla10.Tablasdemultiplicar(numero, 1);

           
        }
    }
}




