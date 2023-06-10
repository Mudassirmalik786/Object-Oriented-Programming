using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            firstOperation(books);
            SecondOperation();

        }

        private static void Book(string authorName, int pages, List<string> chapters, int bookMark, int price)
        {
            throw new NotImplementedException();
        }
        static void firstOperation(List<Book> books)
        {
            Console.Write("Enter name of author: ");
            string authorName = Console.ReadLine();
            Console.Write("Enter pages in this book: ");
            int pages = int.Parse(Console.ReadLine());
            List<string> chapters = new List<string>();
            Console.Write("Enter name of chapter: ");
            chapters[0] = Console.ReadLine();
            for (int x = 0; x < 4; x++)
            {
                Console.Write("Enter name of chapter: ");
                chapters[x] = Console.ReadLine();
            }
            Console.Write("Enter page Number on which book mark is present: ");
            int bookMark = int.Parse(Console.ReadLine());
            Console.Write("Enter price of this book: ");
            int price = int.Parse(Console.ReadLine());
            Book(authorName, pages, chapters, bookMark, price);
        }
        static void SecondOperation()
        {
            Book book = new Book();
            Console.WriteLine("Enter page you want to see bookMark is present or not: ");
            int bookMark = int.Parse(Console.ReadLine());
            float bock = book.getBookMark();
            Console.WriteLine("The bookMark is on " + bock + "page");
        }
        static void ThirdOperation()
        {
            Book book = new Book();
            Console.WriteLine("Enter the number of Chapter: ");
            int chapterNumber = int.Parse(Console.ReadLine());
            List<string> books = book.getChapter(chapterNumber);
            if(chapterNumber == 1)
            {
                Console.WriteLine(books[0]); 
            }
            else if (chapterNumber == 2)
            {
                Console.WriteLine(books[1]);
            }
            else if (chapterNumber == 3)
            {
                Console.WriteLine(books[2]);
            }
            else if (chapterNumber == 4)
            {
                Console.WriteLine(books[3]);
            }
        }
    }
}
