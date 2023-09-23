﻿using System.Text;

namespace AuthorApplication2.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\authors.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExits = System.IO.File.Exists(fName);
            if (isFileExits)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {

                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);

                            }
                        }
                    }
                }

            }
            return list;

        }
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            //author.DOB = DateTime.Parse(data[2]);
            author.DOB = DateTime.Parse(data[4]);
             author.TotalBooks = int.Parse(data[2]);
            author.Royalty = data[3];
            return author;
        }

        //private static Author StringToAuthor(String[] data,Author author) { }
        //public static Author FindAuthuorById(int id) 
        //{ }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"C:\temp\authors.txt";
            String strAuthor = $"{pAuthor.AuthorID}, {pAuthor.AuthorName}, {pAuthor.TotalBooks}, {pAuthor.Royalty}, {pAuthor.DOB}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\authors.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != id)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.TotalBooks}, {author.Royalty}, {author.DOB} {Environment.NewLine}");

                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
        //public static void SaveAllAuthorsToFile(Dictionary<int , Author>) { }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;

            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            string fName = @"c:\temp\authors.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != pAuthor.AuthorID)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.TotalBooks}, {author.Royalty}, {author.DOB} {Environment.NewLine}");
                }
                else
                {
                    sbAuthors.Append($"{pAuthor.AuthorID}, {pAuthor.AuthorName}, {pAuthor.TotalBooks}, {pAuthor.Royalty}, {pAuthor.DOB} {Environment.NewLine}");
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
    }
}
