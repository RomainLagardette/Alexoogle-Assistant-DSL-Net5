using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IdpInterpretCommand.Expressions
{
    public interface IInterpretExpression
    {
        public void Interpret(ComplexeChangeContext context);
    }
}
