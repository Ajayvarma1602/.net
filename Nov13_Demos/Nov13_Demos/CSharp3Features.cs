using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov13_Demos
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    public int BookPrice { get; set; }
        

    }


    class CSharp3Features
    {
        public static void Main()
        {
            Book b = new Book();
            b.BookId = 10;
            b.BookName = "guyu";
            b.BookPrice = 400;
        }
    }
}
