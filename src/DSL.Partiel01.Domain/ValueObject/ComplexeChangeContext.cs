using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Domain.ValueObject
{
    public class ComplexeChangeContext
    {
        public CommandType Type { get; set; }
        public SubCommandType SubType { get; set; }
        public string RoomName { get; set; }
        public string ThingName { get; set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(RoomName))
            {
                RoomName = name;
            }
            else if (string.IsNullOrWhiteSpace(ThingName))
            {
                ThingName = name;
            }
        }
    }
}
