using Core.Ports;
using Domain.Entities;
using Domain.ValueObject;
using Infrastructure.IdpInterpretCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Adapters
{
    public class IdpInterpretCommand : IInterpretCommand
    {
        public InterpretCommandResult InterpretComplexeCommand(Housing housing, string command)
        {
            var parser = new Parser();
            parser.Parse(command);
            return new InterpretCommandResult(parser.Evaluate(housing));
        }
    }
}
