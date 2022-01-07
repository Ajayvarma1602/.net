using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov_16_Demos
{
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookPrice { get; set; }
    }
    class BookCollection
    {
        Book[] books = new Book[3];
public int Size
        {

            get { return books.Length; }
        }
        public Book this[int i]
        {
            set { books[i] = value; }
            get { return books[i]; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookList = new BookCollection();
            //bookList[0] = new Book { BookId=101,BookName = "2 states", BookPrice = 300 };
            for (int i = 0; i <bookList.Size; i++)
            {
                Book b = new Book();
                Console.WriteLine("enter bookid= ");
                b.BookId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter bookname ");
                b.BookName = Console.ReadLine();
                Console.WriteLine("enter book price ");
                b.BookPrice = Convert.ToInt32(Console.ReadLine());

                bookList[i] = b;


            }
            for (int i = 0; i <bookList.Size; i++)
            {
                Console.WriteLine("id:"+bookList[i].BookId);
                Console.WriteLine("name:"+bookList[i].BookName);
                Console.WriteLine("price:"+bookList[i].BookPrice);
                Console.ReadLine();
            }
        }
    }
}
