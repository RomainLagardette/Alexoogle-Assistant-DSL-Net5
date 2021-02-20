using Domain.Enums;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IdpInterpretCommand.Expressions
{
    public class CommandInterpretExpression : IInterpretExpression
    {
        private readonly CommandType _subCommandType;

        public CommandInterpretExpression(CommandType commandType)
        {
            _subCommandType = commandType;
        }

        public void Interpret(ComplexeChangeContext context)
        {
            context.SetType(_subCommandType);
        }
    }
}
