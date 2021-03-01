using Application.InterpretCommand.Expressions;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IdpInterpretCommand
{
    public class Parser
    {
        private readonly IList<IInterpretExpression> expressions = new List<IInterpretExpression>();

        public void Parse(string command)
        {
            foreach (var token in command.Split(" "))
            {
                if (token.Equals("please", StringComparison.InvariantCultureIgnoreCase)
                    || token.Equals("?", StringComparison.InvariantCultureIgnoreCase))
                {
                    expressions.Add(new TerminalInterpretExpression());
                }
                else if (token.Equals("switch", StringComparison.InvariantCultureIgnoreCase))
                {
                    expressions.Add(new CommandInterpretExpression(CommandType.Switch));
                }
                else if (token.Equals("is", StringComparison.InvariantCultureIgnoreCase))
                {
                    expressions.Add(new CommandInterpretExpression(CommandType.Is));
                }
                else if (token.Equals("on", StringComparison.InvariantCultureIgnoreCase))
                {
                    expressions.Add(new SubCommandInterpretExpression(SubCommandType.On));
                }
                else if (token.Equals("off", StringComparison.InvariantCultureIgnoreCase))
                {
                    expressions.Add(new SubCommandInterpretExpression(SubCommandType.Off));
                }
                else
                {
                    expressions.Add(new NameInterpretExpression(token));
                }
            }
        }

        public string Evaluate(Housing housing)
        {
            ComplexeChangeContext context = new ComplexeChangeContext();
            foreach (IInterpretExpression expression in expressions)
            {
                expression.Interpret(context);
            }
            return context.Result(housing);
        }
    }
}
