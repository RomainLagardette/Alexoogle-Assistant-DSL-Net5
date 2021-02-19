using DSL.Partiel01.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Core.Ports
{
    public interface IInterpretCommand
    {
        public ComplexeChangeContext InterpretComplexeCommand(string command);
    }
}
