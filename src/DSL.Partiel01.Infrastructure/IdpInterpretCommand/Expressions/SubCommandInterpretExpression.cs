using DSL.Partiel01.Domain.Enums;
using DSL.Partiel01.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Infrastructure.IdpInterpretCommand.Expressions
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
            context.SubType = _subCommandType; ;
        }
    }
}
