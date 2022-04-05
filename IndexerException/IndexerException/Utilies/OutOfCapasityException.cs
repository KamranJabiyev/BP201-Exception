using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerException.Utilies
{
    class OutOfCapasityException:Exception
    {
        public OutOfCapasityException(string message) : base(message)
        {

        }
    }
}
