using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public string name;
            public string date;
            public string author;
            public string publisher;
            public string publishCompany;
            public string rEditor;
            public string planner;
            public string editor;
            public string designer;
        }
        static void Main(string[] args)
        {
            List<Book> book = new List<Book>();
            book.Add(new Book()
            {
                name = "PHP 프로그래밍 입문",
                date = "2013년 5월 20일",
                author = "황재호",
                publisher = "김태헌",
                rEditor = "김현용",
                publishCompany = "한빛아카데미(주)",
                planner = "김이화",
                editor = "김이화",
                designer = "여동일"
            });

        }
    }
}
