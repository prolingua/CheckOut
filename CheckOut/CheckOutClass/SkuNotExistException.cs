﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.CheckOutClass
{
    public class SkuNotExistException : Exception
    {
        public SkuNotExistException(string message)
            : base(message)
        {
        }
    }
}
