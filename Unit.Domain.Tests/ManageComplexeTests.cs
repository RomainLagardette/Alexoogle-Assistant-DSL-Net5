using DSL.Partiel01.Domain;
using DSL.Partiel01.Domain.Builders;
using DSL.Partiel01.Domain.Entities;
using DSL.Partiel01.Domain.Extensions;
using System;
using Xunit;

namespace Unit.Domain.Tests
{
    public class ManageComplexeTests
    {
        [Fact]
        public void CreateHousingWithRoomsAndThings()
        {
            Complexe romainComplexe = new ComplexeBuilder()
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

            Assert.NotEmpty(romainComplexe.Housings);
            Assert.Equal("My house", romainComplexe.GetHousing("My house").Name);
            Assert.Equal("Bathroom", romainComplexe.GetHousing("My house").GetRoom("Bathroom").Name);
            Assert.Equal("hairdryer", romainComplexe.GetHousing("My house").GetRoom("Bathroom").GetThing("hairdryer").Name);
        }
    }
}
