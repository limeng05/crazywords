using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace WordPuzzle
{
    public interface DataSource
    {
        public IEnumerable<Item> QueryAll(Char hintChar, int index);

        //public IEnumerable<Item> QueryTopN(Char hintChar, int index
    }
}
