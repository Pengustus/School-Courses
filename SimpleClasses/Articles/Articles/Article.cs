using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public class Article
    {
        private string title;
        private string content;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public Article()
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit()
        {

        }

        public void ChangeAuthor()
        {

        }

        public void Rename()
        {

        }
    }
}
