using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace WordPuzzle
{
    public class DataSource
    {
        public static MongoClient client = new MongoClient("mongodb://crazywords.cloudapp.net");
    }
}
