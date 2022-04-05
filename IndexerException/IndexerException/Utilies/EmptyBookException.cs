using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerException.Utilies
{
    public class EmptyBookException:Exception
    {
        public EmptyBookException(string message):base(message)
        {

        }
    }
}
