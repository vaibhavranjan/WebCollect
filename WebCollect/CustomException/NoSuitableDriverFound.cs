using System;
using System.Collections.Generic;
using System.Text;

namespace WebCollect.CustomException
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {

        }
    }
}
