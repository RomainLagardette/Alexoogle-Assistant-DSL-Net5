using Domain.Entities;
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
                    return "Je ne vous ai pas compris...";
            }
        }

        private string Is(Thing thing)
        {
            if (SubCommandType.On == subType)
                return thing.IsOn ? $"{thing.Name} est bien allumé" : $"{thing.Name} n'est pas allumé";
            return !thing.IsOn ? $"{thing.Name} est bien éteinte" : $"{thing.Name} n'est pas éteinte";
        }

        private string Switch(Thing thing)
        {
            if (SubCommandType.On == subType)
            {
                if (!thing.IsOn)
                {
                    thing.SwitchOn();
                    return $"J'allume {thing.Name}";
                }
                return $"{thing.Name} est déjà allumé";
            }
            if (thing.IsOn)
            {
                thing.SwitchOff();
                return $"J'éteins {thing.Name}";
            }
            return $"{thing.Name} est déjà éteinte";
        }
    }
}