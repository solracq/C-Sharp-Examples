using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Contact
    {
        public int age;

        public void F()
        {
            age = 18;
        }

        public void G()
        {
            int age = 36;
            Console.WriteLine(age);
        }
    }

    class Methods
    {
        public void Search(string name, int age, string company)
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Company: {0}", company);
        }

        public void Search(string name, int age, string company, int salary)
        {
            Search(name, age, company);
            Console.WriteLine("Salary: {0}", salary);
        }

        public void Search(string name, int age, string company, int salary, float ratio)
        {
            Search(name, age, company, salary);
            Console.WriteLine("Ratio: {0}", ratio);
        }

        public void Search(string name, int age, string company, int salary, float ratio, string hobbies = "Dancing Salsa") // Optional parameter at the end always
        {
            Search(name, age, company, salary, ratio);
            Console.WriteLine("Hobbies: {0}", hobbies);
        }

        public void Search2(string nickname, string address, int zipcode, string cartype = "Porsche Cayman")
        {
            Console.WriteLine("Nickname: {0}", nickname);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Zipcode: {0}", zipcode);
            Console.WriteLine("Car Type: {0}", cartype);
        }

    }

    class EmailServices
    {
        public bool VerifyEmailAddress(string emailAddr)
        {
            bool ea;
            if (emailAddr == "yuzhang@hotmail.com")
                ea = true;
            else
                ea = false;

                return ea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();  // Instantating the Contact class
            Console.WriteLine(contact.age);
            contact.F();
            Console.WriteLine(contact.age);
            contact.G();
            Console.WriteLine(contact.age);

            Methods methods = new Methods(); // Instantating the Methods class

            // Method overloading with optional parameters and a named argument at the end
            methods.Search("Yu Zhang", 22, "BIMBO", 15000, 10, hobbies:"watching movies");
            methods.Search2("Yuyis", "Av. Siempreviva", 72000);

            EmailServices emailServices = new EmailServices(); // Instantating the EmailServices class
            bool valid = emailServices.VerifyEmailAddress("yuzhang@hotmail.com");
            bool invalid = emailServices.VerifyEmailAddress("yuyis@hotmail.com");
            Console.WriteLine("The yuzhang@hotmail is: {0}", valid);
            Console.WriteLine("The yuyis@hotmail is: {0}", invalid);
        }
    }
}
