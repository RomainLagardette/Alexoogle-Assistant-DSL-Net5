using System;
using System.Collections.Generic;
using DSL.Partiel01.Core.Expressions;
using DSL.Partiel01.Domain;
using DSL.Partiel01.Domain.Builders;
using DSL.Partiel01.Domain.Entities;
using DSL.Partiel01.Domain.Enums;
using DSL.Partiel01.Domain.Extensions;

namespace DSL.Partiel01.Core.Services
{
    public class ComplexeService
    {
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

        

    }
}
