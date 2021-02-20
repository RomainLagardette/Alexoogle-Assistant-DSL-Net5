using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class EmptyException : Exception
    {
        public EmptyException(string emptyParameter) : base($"{emptyParameter} is empty")
        {
        }
    }
}
