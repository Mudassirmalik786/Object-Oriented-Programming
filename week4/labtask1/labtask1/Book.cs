using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    class Book
    {
        public string authorName;
        public int pages;
        public List<string> chapters = new List<string>();
        public int bookMark;
        public int price;
        public Book(string authorName, int pages, List<string> chapters, int bookMark, int price)
        {
            this.authorName = authorName;
            this.pages = pages;
            this.chapters = chapters;
            this.bookMark = bookMark;
            this.price = price;
        }
        public Book()
        {

        }
        public List<string> getChapter(int chapterNumber)
        {
            for(int i = 0; i < chapters.Count; i++)
            {
                if (chapterNumber == i)
                {
                    return chapters;
                }
            }
            return null;
        }
        public int getBookMark()
        {
            return bookMark;
        }
        public void setBookMark(int bookMark)
        {
            this.bookMark = bookMark;
        }
        public int getBookprice()
        {
            return price;
        }
        public void setBookPrice(int newPrice)
        {
            newPrice = price;
        }
    }
}
