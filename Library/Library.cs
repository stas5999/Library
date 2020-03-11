using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public Library(string author, string name)
        {
            Author = author;
            Name = name;
        }
    }
}
