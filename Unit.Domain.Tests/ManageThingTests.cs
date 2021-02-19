using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Unit.Domain.Tests
{
    public class ManageThingTests
    {
        [Fact]
        public void CreateThings()
        {
            var livingRoomKitchen = "Kitchen".Light();
            Assert.NotNull(livingRoomKitchen);
            var livingRoomPlug = "Living room".Plug();
            Assert.NotNull(livingRoomPlug);
        }

        [Fact]
        public void SwitchThings()
        {
            var livingRoomKitchen = "Kitchen".Light();
            Assert.False(livingRoomKitchen.IsOn);
            livingRoomKitchen.SwitchOn();
            Assert.True(livingRoomKitchen.IsOn);
        }
    }
}
