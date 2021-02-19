using System;
using System.Collections.Generic;
using System.Text;

namespace DSL.Partiel01.Domain.Exceptions
{
    public class EmptyException : Exception
    {
        public EmptyException(string emptyParameter) : base($"{emptyParameter} is empty")
        {
        }
    }
}
