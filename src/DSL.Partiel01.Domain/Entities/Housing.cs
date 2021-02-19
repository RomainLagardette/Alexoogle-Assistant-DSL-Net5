using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSL.Partiel01.Domain
{
    public class Housing
    {
        private readonly List<Room> _rooms = new List<Room>();

        public string Name { get; private set; }

        public Housing(string name)
        {
            Name = name;
        }

        public Room NewRoom(Room room)
        {
            _rooms.Add(room);
            return room;
        }

        public Room GetRoom(string name)
        {
            return _rooms.Single(_ => _.Name == name);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            foreach (var room in _rooms)
            {
                sb.AppendLine("-" + room.ToString());
            }
            return sb.ToString();
        }
    }
}
