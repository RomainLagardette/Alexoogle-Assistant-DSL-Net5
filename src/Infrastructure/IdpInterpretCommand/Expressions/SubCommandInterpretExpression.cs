using Domain.Enums;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IdpInterpretCommand.Expressions
{
    public class SubCommandInterpretExpression : IInterpretExpression
    {
        private readonly SubCommandType _subCommandType;

        public SubCommandInterpretExpression(SubCommandType subCommandType)
        {
            _subCommandType = subCommandType;
        }

        public void Interpret(ComplexeChangeContext context)
        {
            context.SetSubType(_subCommandType);
        }
    }
}
