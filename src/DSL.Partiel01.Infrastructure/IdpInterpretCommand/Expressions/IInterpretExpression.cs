using DSL.Partiel01.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Infrastructure.IdpInterpretCommand.Expressions
{
    public interface IInterpretExpression
    {
        public void Interpret(ComplexeChangeContext context);
    }
}
