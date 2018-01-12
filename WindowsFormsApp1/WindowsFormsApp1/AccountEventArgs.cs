﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AccountEventArgs
    {
        public readonly string Message;
        public decimal Rest;
        public decimal OperationSum;

        public AccountEventArgs(string message, decimal rest, decimal operationSum)
        {
            Message = message;
            Rest = rest;
            OperationSum = operationSum;
        }
    }
}
