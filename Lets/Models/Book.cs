using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets.Models
{

    public class Book
    {
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string img { get; set; }
        public int Pages { get; set; }
        public DateTime Publication { get; set; }
        
        

    }
}
