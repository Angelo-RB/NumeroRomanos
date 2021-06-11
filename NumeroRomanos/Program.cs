using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorRomano.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════╗");
            Console.WriteLine("║Conversor de Números Romanos║");
            Console.WriteLine("╚════════════════════════════╝");

            ConversorNumeroIndoArabico conversorIndoArabico = new ConversorNumeroIndoArabico();

            Console.WriteLine(conversorIndoArabico.ConversorNumeroArabicoPrimario(6));

            Console.WriteLine();

            ConverterNumeroRomano conversorRomano = new ConverterNumeroRomano();

            Console.WriteLine(conversorRomano.ConverterNumeroRomanoSecundario());
            

            Console.ReadLine();
        }
    }
}

