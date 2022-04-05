using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerException.Models
{
    class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
