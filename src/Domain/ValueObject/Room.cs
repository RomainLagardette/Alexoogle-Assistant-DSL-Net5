using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.ValueObject
{
    public class Room
    {
        private readonly List<Thing> _things = new List<Thing>();

        public string Name { get; private set; }

        public Room Called(string name)
        {
            Name = name;
            return this;
        }

        public Room Put(Thing thing)
        {
            _things.Add(thing);
            return this;
        }

        public Thing GetThing(string name)
        {
            return _things.Single(_ => _.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            foreach (var thing in _things)
            {
                sb.AppendLine("--" + thing.ToString());
            }
            return sb.ToString();
        }
    }
}
