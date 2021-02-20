using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Ports
{
    public interface IInterpretCommand
    {
        public InterpretCommandResult InterpretComplexeCommand(Housing housing, string command);
    }
}
