using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.InterpretCommand.Expressions
{
    public class NameInterpretExpression : IInterpretExpression
    {
        private readonly string _name;

        public NameInterpretExpression(string name)
        {
            _name = name;
        }

        public void Interpret(ComplexeChangeContext context)
        {
            context.SetName(_name);
        }
    }
}
