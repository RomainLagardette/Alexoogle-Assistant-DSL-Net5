using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.InterpretCommand.Expressions
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
