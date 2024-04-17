using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Avant
{
    // LibraryAvant.cs:
    // LibraryAvant class represents a library that directly depends on concrete ReaderAvant class, violating DIP.
    internal class LibraryAvant
    {
        private  ReaderAvant _reader;

        public LibraryAvant()
        {
            _reader = new ReaderAvant();
        }

        public void LendBook(string book)
        {
            _reader.ReadBook(book);
        }
    }
}
