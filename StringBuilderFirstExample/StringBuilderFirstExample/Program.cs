using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderFirstExample
{
    class Contact
    {
        //private string firstName;
        //private string lastName;

        // Public property to be able to write in the Main. However, declared fields in classes should be Private by default
        public DateTime DateOfBirth;

        // Automatic property to be able to read and writhe private value in the class
        public String FirstName
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        // Automatic property that combines two fields
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Name: {0}\r\n", this.FullName);
            stringBuilder.AppendFormat("Date of Birth: {0}\r\n", this.DateOfBirth);
            return stringBuilder.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            c.FirstName = "Yu";
            c.LastName = "Zhang";
            c.DateOfBirth = new DateTime(1983, 9, 3);
            string name = c.FullName;

            Console.WriteLine(c.ToString());

            DateTime datevalue = new DateTime(2013,9,20);
            Console.WriteLine("This is the cute name {0}", name);
            Console.WriteLine(datevalue.Date);
        }
    }
}
