using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Ports
{
    public class InterpretCommandResult
    {
        public string Message { get; set; }

        public InterpretCommandResult(string result)
        {
            Message = result;
        }
    }
}
