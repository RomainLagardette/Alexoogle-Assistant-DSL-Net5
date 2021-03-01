using Domain.Entities;
using Infrastructure.IdpInterpretCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.InterpretCommand
{
    public class IdpInterpretCommand
    {
        public string InterpretComplexeCommand(Housing housing, string command)
        {
            var parser = new Parser();
            parser.Parse(command);
            return parser.Evaluate(housing);
        }
    }
}
