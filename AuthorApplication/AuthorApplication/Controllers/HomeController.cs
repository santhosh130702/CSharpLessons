using AuthorApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
namespace AuthorApplication.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Finder()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AddAuthorDetail()
        {
            AuthorModel author = new AuthorModel();
            return View(author);
        }

        public IActionResult SaveNewBook(AuthorModel pauthor)
        {
            String fName = @"c:\temp\author.txt";
            string strBook = $"{pauthor.AuthorID}, {pauthor.AuthorName}, {pauthor.TotalBooks}, {pauthor.Royalty}, {pauthor.DOB}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook);
            }

            return View(pauthor);
        }

        public IActionResult ListAllBook()
        {
            String fName = @"c:\temp\author.txt";
            List<AuthorModel> list = new List<AuthorModel>();
            using (StreamReader sr = new StreamReader(fName, true))
            {
                string strauthor = $" {sr.ReadLine()}";
                String[] data = strauthor.Split(',');
                AuthorModel author = StringToAuthor(data, new AuthorModel());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strauthor = $"{sr.ReadLine()}";
                    data = strauthor.Split(",");
                    author = StringToAuthor(data, new AuthorModel());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private AuthorModel StringToAuthor(string[] data, AuthorModel author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.TotalBooks = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;
        }

        //public IActionResult Editauthor(int AuthorID)
        //{   
        //    AuthorModel authoredit = new AuthorModel();
        //    return View();
        ////}
        //public IActionResult Delete(int? i)
        //{
        //    String fName = @"c:\temp\author.txt";
        //    List<AuthorModel> list = new List<AuthorModel>();
        //    using (StreamReader sr = new StreamReader(fName, true))
        //    {
        //        var st =list.Find(c=>c.AuthorID == i);
        //        list.Remove(st);
        //    }
        //    return View(list);
        //}
        public IActionResult Edit(String eid)
        {
            List<AuthorModel> list = Find(int.Parse(eid));
            AuthorModel author = list[0];
            return View(author);
        }
        public IActionResult ModifyAuthor(AuthorModel pauthor)
        {
            String fName = @"C:\temp\authors1.txt";
            String strAuthor = $"{pauthor.AuthorID}, {pauthor.AuthorName}, {pauthor.TotalBooks}, {pauthor.Royalty}, {pauthor.DOB}";
            List<AuthorModel> list = new List<AuthorModel>();
            list = Find(pauthor.AuthorID);
            if (list.Count != 0)
            {
                int index = FindIndex(pauthor.AuthorID);
                DeleteLine(index);
            }
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(pauthor);
        }
        public ActionResult Delete(String did)
        {

            List<AuthorModel> list = Find(int.Parse(did));

            AuthorModel author = list[0];
            int index = FindIndex(int.Parse(did));
            DeleteLine(index);
            return View(author);
        }
        private List<AuthorModel> Find(int id)
        {
            String fName = @"C:\temp\authors1.txt";
            List<AuthorModel> list = new List<AuthorModel>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                AuthorModel author = StringToAuthor(data, new AuthorModel());
                if (author.AuthorID == id)
                {
                    list.Add(author);
                }

                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new AuthorModel());
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                    }
                }
            }
            return list;
        }
        private int FindIndex(int id)
        {
            String fName = @"C:\temp\authors1.txt";
            List<AuthorModel> list = new List<AuthorModel>();
            int count = 0;
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                AuthorModel author = StringToAuthor(data, new AuthorModel());
                bool flag = true;
                if (flag)
                    count++;
                if (author.AuthorID == id)
                {
                    list.Add(author);
                    flag = false;
                }

                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new AuthorModel());
                    if (flag)
                        count++;
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                        flag = false;
                    }
                }
            }
            return count;
        }
        private void DeleteLine(int index)
        {
            string filePath = @"C:\temp\authors1.txt";
            int line_Delete = index;
            string tempFilePath = @"C:\temp\tempauthor.txt";
            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                int count = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count != line_Delete)
                    {
                        writer.WriteLine(line);
                        count++;
                    }
                }
            }
            using (StreamReader reader = new StreamReader(tempFilePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }

                }
            }

        }

    }
}