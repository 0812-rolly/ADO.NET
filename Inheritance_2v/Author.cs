using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2v
{
    class Author
    {
        private string firstname;
        private string lastname;
        private int birthdate;

        public Author(string fname, string lname, int birthdate)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.birthdate = birthdate;
        }

        public Author(Author auth)
        {
            this.firstname = auth.firstname;
            this.lastname = auth.lastname;
            this.birthdate = auth.birthdate;
        }

        public string FirstName
        {
            get => firstname;
            set => firstname = value;
        }

        public string LastName
        {
            get => lastname;
            set => lastname = value;
        }

        public int BirthDate
        {
            get => birthdate;
            set => birthdate = value;
        }

        public override string ToString()
        {
            return lastname + " " + firstname + ", Год рождения автора: " + birthdate;
        }
    }
}
