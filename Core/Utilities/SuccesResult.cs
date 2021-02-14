﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccesResult : Result
    {
        public SuccesResult(string message) : base(true, message)
        {

        }
        public SuccesResult() : base(true)
        {

        }
    }
}
