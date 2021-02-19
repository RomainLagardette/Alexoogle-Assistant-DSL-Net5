using DSL.Partiel01.Domain.Enums;
using DSL.Partiel01.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Infrastructure.IdpInterpretCommand.Expressions
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
            context.Type = _subCommandType;
        }
    }
}
