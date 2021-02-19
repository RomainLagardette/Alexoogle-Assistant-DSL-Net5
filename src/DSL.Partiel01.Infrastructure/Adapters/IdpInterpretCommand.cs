using DSL.Partiel01.Core.Ports;
using DSL.Partiel01.Domain.ValueObject;
using DSL.Partiel01.Infrastructure.IdpInterpretCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Infrastructure.Adapters
{
    public class IdpInterpretCommand : IInterpretCommand
    {
        public ComplexeChangeContext InterpretComplexeCommand(string command)
        {
            new Parser().Parse(command);
        }
    }
}
