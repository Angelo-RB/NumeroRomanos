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
            Console.WriteLine("Conversor Números Romanos");

            ConversorNumeroIndoArabico conversorIndoArabico = new ConversorNumeroIndoArabico();

            Console.WriteLine(conversorIndoArabico.ConversorNumeroIndoArabicoPrimario(3 + 3));
            Console.ResetColor();

            ConverterNumeroRomano conversorRomano = new ConverterNumeroRomano();

            Console.WriteLine(conversorRomano.ConverterNumeroRomanoSecundario());
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}

