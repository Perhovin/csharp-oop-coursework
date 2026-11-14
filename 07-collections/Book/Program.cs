using System.Collections.Concurrent;
using System.Collections.Immutable;

Book Book1 = new Book();
Book1.Title = "Monsters";
Book1.Author = "GG";
Book1.Pages = 245;

Book Book2 = new Book();
Book2.Title = "Lady";
Book2.Author = "Alex";
Book2.Pages = 167;

Book Book3 = new Book();
Book3.Title = "Jekson";
Book3.Author = "Sasha";
Book3.Pages = 321;

List<Book> Books = [];
Books.Add(Book1);
Books.Add(Book2);
Books.Add(Book3);

foreach (Book INFO in Books)
{
    Console.WriteLine($"{INFO.Title} - {INFO.Pages}");
}