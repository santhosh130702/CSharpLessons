using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    public class Book
    {
        public String Title=String.Empty;   
        public String Author=String.Empty;
        public String Generic=String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages=300;
        public Book()
        {
            Console.WriteLine("BOOK IS CREATED");
        }
        public void OpenBook()
        {
            Console.WriteLine("book is open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"PAGE NO:{pageNo} bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}
