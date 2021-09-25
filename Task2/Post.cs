using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Post
    {
        private int id;
        private String title;
        private String author;
        private String content;
        private DateTime date;

        public Post()
        {
        }
        public Post(int id, String title, String author, String content, DateTime date)
        {
            this.id = id;
            ID = id;
            this.title = title;
            Title = title;
            this.author = author;
            Author = author;
            this.content = content;
            Content = content;
            this.date = date;
            Date = date;
        }

        public int ID { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Content { get; set; }
        public DateTime Date { get; set; }
        public void Stampa()
        {
            Console.WriteLine("Ttile: " + this.title + " | Author: " + this.author + " | Date: " + this.date);
        }
    }
}
