using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2v
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();
            List<Book> books = new List<Book>();
            List<Author> authors = new List<Author>();

            ReadData(stud, authors, books);

            foreach (Student st in stud)
                Console.WriteLine(st.ToString());

            foreach (Book book in books)
                Console.WriteLine(book.ToString());
        }

        static void ReadData(List<Student> stud, List<Author> authors, List<Book> books)
        {
            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/students.txt", Encoding.GetEncoding(1251)))
            {
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string name = dat[0];
                    int age = int.Parse(dat[1]);
                    int weight = int.Parse(dat[2]);
                    int height = int.Parse(dat[3]);
                    int year = int.Parse(dat[4]);
                    int course = int.Parse(dat[5]);
                    int group_number = int.Parse(dat[6]);
                    stud.Add(new Student(name, age, weight, height, year, course, group_number));
                }
            }

            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/authors.txt", Encoding.GetEncoding(1251)))
            {
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string lastname = dat[0];
                    string firstname = dat[1];
                    int birthdate = int.Parse(dat[2]);
                    authors.Add(new Author(firstname, lastname, birthdate));
                }
            }

            using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/books.txt", Encoding.GetEncoding(1251)))
            {
                int i = 0;
                while (!sr.EndOfStream)
                {
                    string[] dat = sr.ReadLine().Split(',');
                    string name = dat[0];
                    int number_of_pages = int.Parse(dat[1]);
                    string publish_house = dat[2];
                    int release_date = int.Parse(dat[3]);
                    int date_of_writing = int.Parse(dat[4]);
                    books.Add(new Book(name, number_of_pages, publish_house, release_date, date_of_writing, authors[i]));

                    i++;
                }
            }
        }
    }
}
