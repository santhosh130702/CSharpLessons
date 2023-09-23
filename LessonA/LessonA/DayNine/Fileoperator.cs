using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayNine
{
    internal class Fileoperator
    {
        public static void FileWriteAllLines()
        {
            String fName = @"c:\temp\myfileA.txt";
            string[] lines =
            {
                "chennai is capital city.",
                "madurai is the temple city",
                "salem is steal city"
            };
            try
            {
                File.WriteAllLines(fName, lines);
                System.Console.WriteLine("file created");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error!!!{e.Message}");
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }



            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = @"c:\temp\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }



        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = @"c:\temp\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static void FileWriteAllText()
        {
            String fNameb = @"c:\temp\myfileB.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
        };
            StringBuilder sb = new StringBuilder(100);
            sb.Append(lines[0]);
            sb.Append(Environment.NewLine); // sb.Append("\\n");
            sb.Append(lines[1]);
            sb.Append(Environment.NewLine);
            sb.Append(lines[2]);
            sb.Append(Environment.NewLine);
            File.WriteAllText(fNameb, sb.ToString());
            System.Console.WriteLine("File Created");
        }
        public static void StreamReaderFromFileDemo()
        {
            StringBuilder line = new StringBuilder(250);
            String fName = @"c:\temp\myfileA.txt";
            using (StreamReader sr = new StreamReader(fName))
            {
                line.Append(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    line.Append(sr.ReadLine());
                    line.Append(Environment.NewLine);
                }
                Console.WriteLine(line.ToString());
            }
            System.Console.WriteLine("Completed");
        }
        public static byte[] Logo
        {
            get
            {
                byte[] logobytes = null;
                if(logobytes == null)
                {
                    logobytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                }
                return logobytes;
            }
        }
    }
}
