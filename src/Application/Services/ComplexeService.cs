using Application.InterpretCommand;
using Domain.Builders;
using Domain.Entities;
using Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ComplexeService
    {
        private readonly IdpInterpretCommand _interpretCommand;

        public ComplexeService()
        {
            _interpretCommand = new IdpInterpretCommand();
        }

        public Complexe GetRomainComplexe()
        {
            Complexe complexe = new ComplexeBuilder()
                .NewHousing("My house")
                .AddRoom(
                    new Room().Called("Bathroom")
                        .Put("hairdryer".Plug())
                        .Put("mirror".Light())
                )
                .NewHousing("Mum flat")
                .AddRoom(
                    new Room().Called("Living room")
                        .Put("tv".Plug())
                        .Put("ceiling".Light().On())
                )
                .AddRoom(
                    new Room().Called("kitchen")
                        .Put("fridge".Plug().On())
                        .Put("cooker".Light())
                );
            return complexe;
        }

        public string InterpretComplexeCommand(Housing housing, string command)
        {
            return _interpretCommand.InterpretComplexeCommand(housing, command);
        }

    }
}
