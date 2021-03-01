using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Thing
    {
        private static int count = 0;

        private readonly int _reference;
        private readonly ThingType _type;

        public string Name { get; private set; }
        public bool IsOn { get; private set; }

        public Thing(ThingType type, string name, bool isOn = false)
        {
            Name = name;
            IsOn = isOn;
            _type = type;
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
