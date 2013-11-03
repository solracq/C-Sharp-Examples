using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactNamespace
{
    public class Contact                      
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;

        // A constructor that takes no parameters is called a default constructor. 
        public Contact()
        {
        }

        // Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.
        public Contact(string firstName, string lastName, DateTime dateOfBirth)   // Default constructor
            :this()
        {   // private fields = parameters
            this.firstName = firstName; // "this" distinguishes between the class fields and the parameters because both have the same name
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public Contact(string nickname, DateTime fiveYearsOldDate)
        {
            firstName = nickname;
            dateOfBirth = fiveYearsOldDate.AddYears(5);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("First Name: {0}\r\n", this.firstName);
            stringBuilder.AppendFormat("Last Name: {0}\r\n", this.lastName);
            stringBuilder.AppendFormat("Date of Birth: {0}\r\n", this.dateOfBirth);
            return stringBuilder.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Default constructors are invoked whenever an object is instantiated by using the new operator and no arguments are provided to new.
            // Contact contact = new Contact();

            Contact contact1 = new Contact("Yu", "Zhang", new DateTime(1983, 9, 3));
            Console.WriteLine(contact1.ToString());

            Contact contact2 = new Contact("Yuyis", new DateTime(1983, 9, 3));
            Console.WriteLine(contact2.ToString());
        }
    }
}
