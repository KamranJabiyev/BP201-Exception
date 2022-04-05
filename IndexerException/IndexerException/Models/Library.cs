using IndexerException.Utilies;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerException.Models
{
    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library(string name,int capasity)
        {
            Name = name;
            books = new Book[capasity];
        }

        public Book this[int index]
        {
            get
            {
                if(index>books.Length-1)
                {
                    throw new OutOfCapasityException("This index is not exist");
                }
                else if(books[index]==null)
                {
                    throw new EmptyBookException("This index is not set");
                }
                return books[index];

            }
            set
            {
                if(index <= books.Length - 1 && books[index] == null)
                {
                    books[index] = value;
                }
            }
        }
    }
}
