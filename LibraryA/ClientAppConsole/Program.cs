using LibraryA;
Book book = new Book();
book.Title = "Ponniyan Selvan";
book.Author = "Kalki";
book.Generic = "Darma";
book.BookPrice = 250;
book.DateOfPublish = new DateTime(1995,06,01);
book.BookmarkPage(200);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addresult = calculator.Add(100, 40);
Console.WriteLine(addresult);
int mulresult = calculator.Multiply(100, 40);
Console.WriteLine(mulresult);
int divideresult = calculator.Divide(100, 40);
Console.WriteLine(divideresult);

