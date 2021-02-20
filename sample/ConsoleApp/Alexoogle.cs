using Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Alexoogle
    {
        public void Demo(ComplexeService complexeService)
        {
            var romainComplexe = complexeService.GetRomainComplexe();
            var selectedHousing = romainComplexe.GetHousing("My house");

            Console.WriteLine("switch {on/off} bathroom {hairdryer/mirror} now");
            Console.WriteLine("is {on/off} bathroom {hairdryer/mirror} ?");
            Console.WriteLine("---------------------");

            string command;
            do
            {
                Console.WriteLine(selectedHousing);
                Console.WriteLine("---------------------");
                Console.WriteLine("Oui, je vous écoute ?");
                command = Console.ReadLine();
                var commandResult = complexeService.InterpretComplexeCommand(selectedHousing, command);
                Console.WriteLine("Ok, " + commandResult);
                Console.WriteLine("---------------------");
            } while (!string.IsNullOrWhiteSpace(command));

            Console.ReadLine();
        }
    }
}
