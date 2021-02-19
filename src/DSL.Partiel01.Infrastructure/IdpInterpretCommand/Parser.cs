using DSL.Partiel01.Core.Expressions;
using DSL.Partiel01.Domain.Enums;
using DSL.Partiel01.Infrastructure.IdpInterpretCommand.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Infrastructure.IdpInterpretCommand
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
    }
}
