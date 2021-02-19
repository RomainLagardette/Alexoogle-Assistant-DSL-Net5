using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Domain
{
    public enum ThingType
    {
        Light,
        Plug,
    }

    public class Thing
    {
        private static int count = 0;

        private readonly int _reference;
        public string Name { get; private set; }
        private readonly ThingType _type;

        public bool IsOn { get; private set; }

        public Thing(ThingType type, string name)
        {
            _type = type;
            Name = name;
            _reference = ++count;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        private string status => IsOn ? "on" : "off";

        public override string ToString()
        {
            return $"{_type} '{Name}' is {status} ({_reference})";
        }
    }
}
