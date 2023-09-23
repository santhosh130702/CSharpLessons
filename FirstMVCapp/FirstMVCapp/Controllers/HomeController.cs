using FirstMVCapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Xml.Linq;

namespace FirstMVCapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoLogin(String txtUser,String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtpwd}";
            return View();
        }
        public IActionResult SayHello(string name)
        {   
            if(String.IsNullOrEmpty(name)) {
                ViewData["v1"] = "name is empty";
            }
            else
                ViewData["v1"]=name;
            return View();
        }
        public IActionResult Add(int x,int y)
        {
            int result = x + y;
            ViewData["result"] = result;
            return View(result);    
           
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["result"] = result;
            return View("Add");

        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["result"] = result;
            return View("Add");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    //working with book object
    public IActionResult AddNewBook()
        {   
            Book book=new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pbook)
        {
            String fName = @"c:\temp\book.txt";
            string strBook = $"{pbook.BookID},{pbook.Title},{pbook.AuthorName},{pbook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook);
            }

            return View(pbook);
        }

      public IActionResult ListAllBook() 
      {
          String fName = @"c:\temp\book.txt";
          List<Book> list = new List<Book>();
          using (StreamReader sr=new StreamReader(fName,true))
          {
              string strBook = $" {sr.ReadLine()}";
              String[] data = strBook.Split(',');
              Book book = StringToBook(data, new Book());
              list.Add(book);
              while (!sr.EndOfStream)
              {
                  strBook = $"{sr.ReadLine()}";
                  data = strBook.Split(",");
                  book = StringToBook(data, new Book());
                  list.Add(book);
              }
          }
          return View(list);
      }
        private Book StringToBook(string[] data, Book book)
        {
           // if()
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;



        }
    }

    }
