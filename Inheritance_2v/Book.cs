using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2v
{
    class Book
    {
        private string name;
        private int number_of_pages;
        private string publish_house;
        private int release_date;
        private int date_of_writing;
        private Author author;

        public Book(string name, int number_of_pages, string publish_house,
            int release_date, int date_of_writing, Author author)
        {
            this.name = name;
            this.number_of_pages = number_of_pages;
            this.publish_house = publish_house;
            this.release_date = release_date;
            this.date_of_writing = date_of_writing;
            this.author = author;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Count_Of_Pages
        {
            get => number_of_pages;
            set => number_of_pages = value;
        }

        public string Publishing_House
        {
            get => publish_house;
            set => publish_house = value;
        }

        public int ReleaseDate
        {
            get => release_date;
            set => release_date = value;
        }

        public int Date_Of_Writing
        {
            get => date_of_writing;
            set => date_of_writing = value;
        }

        public Author Author
        {
            get => author;
            set => author = value;
        }

        public override string ToString()
        {
            string result = "Название: " + Name + '\n';
            result += "Количество страниц: " + Count_Of_Pages + '\n';
            result += "Издательство: " + Publishing_House + '\n';
            result += "Дата издания: " + ReleaseDate + '\n';
            result += "Дата написания произведения: " + Date_Of_Writing + '\n';
            result += "Автор произведения: " + author.ToString() + '\n';
            return result;
        }

    }
}
