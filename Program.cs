using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada;
            double metros, centimetros, quilometros;

            Console.Write("Entre com a medida (em metros): ");
            entrada = Console.ReadLine();

            metros = Convert.ToDouble(entrada);
            centimetros = metros * 100;
            quilometros = metros / 1000;

            Console.WriteLine ("\n--- Equivalencia ---");
            Console.WriteLine($"{centimetros:N2} CM");
            Console.WriteLine($"{metros:N1} M");
            Console.WriteLine($"{quilometros:N3} KM");

            
        }
    }
}
