using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Ports
{
    public class InterpretCommandResult
    {
        public string Result { get; set; }

        public InterpretCommandResult(string result)
        {
            Result = result;
        }
    }
}
