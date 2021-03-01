using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.InterpretCommand.Expressions
{
    public interface IInterpretExpression
    {
        public void Interpret(ComplexeChangeContext context);
    }
}
