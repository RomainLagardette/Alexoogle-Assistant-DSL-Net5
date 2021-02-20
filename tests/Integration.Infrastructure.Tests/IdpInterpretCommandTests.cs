using Domain.Enums;
using Domain.ValueObject;
using Infrastructure.Adapters;
using System;
using Xunit;

namespace Integration.Infrastructure.Tests
{
    public class IdpInterpretCommandTests
    {
        public class BasicHousing
        {
            private const string light1Name = "light1";
            private const string room1Name = "room1";
            private const string housing1Name = "housing1";

            private Housing InitBasicHousing()
            {
                var light1 = new Thing(ThingType.Light, light1Name);

                var room1 = new Room().Called(room1Name);
                room1.Put(light1);

                var housing1 = new Housing(housing1Name);
                housing1.NewRoom(room1);

                return housing1;
            }

            [Fact]
            public void InterpretComplexeCommand_SwitchOnLightOff_ObtainsGoodMessage()
            {
                var housing = InitBasicHousing();

                var result = new IdpInterpretCommand().InterpretComplexeCommand(housing, $"switch on {room1Name} {light1Name}");

                var thing = housing.GetRoom(room1Name).GetThing(light1Name);

                Assert.Equal($"J'allume {thing.Name}", result.Message);
            }

            [Fact]
            public void InterpretComplexeCommand_SwitchOffLightOff_ObtainsGoodMessage()
            {
                var housing = InitBasicHousing();

                var result = new IdpInterpretCommand().InterpretComplexeCommand(housing, $"switch off {room1Name} {light1Name}");

                var thing = housing.GetRoom(room1Name).GetThing(light1Name);

                Assert.Equal($"{thing.Name} est d�j� �teinte", result.Message);
            }

            [Fact]
            public void InterpretComplexeCommand_SwitchOnLightOff_LightIsOn()
            {
                var housing = InitBasicHousing();

                var result = new IdpInterpretCommand().InterpretComplexeCommand(housing, $"switch on {room1Name} {light1Name}");

                var thing = housing.GetRoom(room1Name).GetThing(light1Name);

                Assert.True(thing.IsOn);
            }

            [Fact]
            public void InterpretComplexeCommand_SwitchOnLightOn_LightIsOn()
            {
                var housing = InitBasicHousing();

                var result = new IdpInterpretCommand().InterpretComplexeCommand(housing, $"switch on {room1Name} {light1Name}");

                var thing = housing.GetRoom(room1Name).GetThing(light1Name);

                Assert.True(thing.IsOn);
            }

            [Fact]
            public void InterpretComplexeCommand_SwitchOffLightOn_LightIsOff()
            {
                var housing = InitBasicHousing();

                var result = new IdpInterpretCommand().InterpretComplexeCommand(housing, $"switch off {room1Name} {light1Name}");

                var thing = housing.GetRoom(room1Name).GetThing(light1Name);

                Assert.False(thing.IsOn);
            }
        }
    }
}
