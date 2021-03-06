﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFe.Utils.Exceptions
{
    public class ValidationException : Exception
    {
        private string message;

        public override string ToString()
        {
            return "Erros da validação: " + this.message;
        }

        public ValidationException(string msg)
        {
            this.message = msg;
            new Exception();
        }
    }
}
