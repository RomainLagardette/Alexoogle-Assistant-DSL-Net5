using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObject
{
    public class ComplexeChangeContext
    {
        private CommandType? type;
        private SubCommandType? subType;
        private string roomName;
        private string thingName;

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(roomName))
            {
                roomName = name;
            }
            else if (string.IsNullOrWhiteSpace(thingName))
            {
                thingName = name;
            }
        }

        public void SetType(CommandType type)
        {
            this.type = type;
        }

        public void SetSubType(SubCommandType subType)
        {
            this.subType = subType;
        }

        public string Result(Housing housing)
        {
            var thing = housing.GetRoom(roomName).GetThing(thingName);
            switch (type)
            {
                case CommandType.Switch:
                    return Switch(thing);
                case CommandType.Is:
                    return Is(thing);
                default:
                    return "I didn't understand you...";
            }
        }

        private string Is(Thing thing)
        {
            if (SubCommandType.On == subType)
                return thing.IsOn ? $"{thing.Name} is on" : $"{thing.Name} is not on";
            return !thing.IsOn ? $"{thing.Name} is off" : $"{thing.Name} is not off";
        }

        private string Switch(Thing thing)
        {
            if (SubCommandType.On == subType)
            {
                if (!thing.IsOn)
                {
                    thing.SwitchOn();
                    return $"I switch on {thing.Name}";
                }
                return $"{thing.Name} is already on";
            }
            if (thing.IsOn)
            {
                thing.SwitchOff();
                return $"I switch off {thing.Name}";
            }
            return $"{thing.Name} is already off";
        }
    }
}