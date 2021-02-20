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

            SystemWriteLine("Exemple :");
            SystemWriteLine("switch {on/off} bathroom {hairdryer/mirror} now");
            SystemWriteLine("is {on/off} bathroom {hairdryer/mirror} ?");
            SystemWriteLine("---------------------");

            string command;
            do
            {
                Console.WriteLine(selectedHousing);
                SystemWriteLine("---------------------");
                AlexoogleWriteLine("Yes ?");
                command = UserReadLine();
                var commandResult = complexeService.InterpretComplexeCommand(selectedHousing, command);
                AlexoogleWriteLine(commandResult);
                SystemWriteLine("---------------------");
            } while (!string.IsNullOrWhiteSpace(command));

            Console.ReadLine();
        }

        private void AlexoogleWriteLine(string output)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Alexoogle: " + output);
        }

        private void SystemWriteLine(string output)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(output);
        }

        private string UserReadLine()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("User: ");
            return Console.ReadLine();
        }
    }
}
