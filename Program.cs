using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            String entrada;
            double metros, centimetros, quilometros, km;

            Console.Write("Entre com a medida (em metros): ");
            entrada = Console.ReadLine();

            metros = Convert.ToDouble(entrada);
            centimetros = metros * 100;
            km = metros / 1000;
            quilometros = metros * 0.001;
           
            Console.WriteLine ("\n--- Equivalencia ---");
            Console.WriteLine($"{centimetros} CM");
            Console.WriteLine($"{metros} M");
            Console.WriteLine($"{km} KM");
            Console.WriteLine($"Sabendo que 1 metro é = 0,001 e você digitou {entrada} a medida é {quilometros} Km");

            
        }
    }
}
