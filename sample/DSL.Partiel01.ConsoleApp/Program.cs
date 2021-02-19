using System;
using DSL.Partiel01.Core;

namespace DSL.Partiel01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var romainComplexe = new ComplexeService().GetRomainComplexe();

            Console.WriteLine(romainComplexe);

            Console.ReadKey();
        }
    }
}
