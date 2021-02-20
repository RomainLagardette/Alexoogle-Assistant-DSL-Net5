using Domain.Enums;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Extensions
{
    public static class ThingExts
    {
        public static Thing Light(this string name)
        {
            return new Thing(ThingType.Light, name);
        }

        public static Thing Plug(this string name)
        {
            return new Thing(ThingType.Plug, name);
        }

        public static Thing On(this Thing thing)
        {
            thing.SwitchOn();
            return thing;
        }
        public static Thing Off(this Thing thing)
        {
            thing.SwitchOff();
            return thing;
        }
    }
}
