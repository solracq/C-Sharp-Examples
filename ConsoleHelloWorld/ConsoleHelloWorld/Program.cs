using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Sakurei Yu");  // Calling full type name. Not necessary as System directive has been called at the begining
            Console.WriteLine("Hello Yu");           // Calling part type name

            int i = 20;
            float f = 20.2f;
            string s = "Yu esta bien chula!";

            Console.WriteLine("This is an {0} value: {1}", i.GetTypeCode(), i);
            Console.WriteLine("This is a {0} value: {1}", f.GetTypeCode(),f);
            Console.WriteLine("This is a {0} value: {1}", s.GetTypeCode(),s);

            var v = true;
            Console.WriteLine("This is a {0} value: {1}", v.GetTypeCode(), v);

            Uri immutableUri = new Uri("http://www.example.com");
            Console.WriteLine("{0} immutable Uri", immutableUri);

            UriBuilder mutableUri = new UriBuilder(immutableUri);
            Console.WriteLine("{0} mutable Uri", mutableUri);

            mutableUri.Scheme = "https";
            mutableUri.Host = "www.example.com";
            mutableUri.Path = "exampleFile.html";
            Console.WriteLine(mutableUri);

            BigInteger b1 = new BigInteger(987321.5401);
            BigInteger b2 = (BigInteger)435623411897L;
            BigInteger b3 = BigInteger.Parse("435623411897");

            Console.WriteLine("b1 = {0}", b1);
            Console.WriteLine("b2 = {0}", b2);
            Console.WriteLine("b3 = {0}", b3);
            Console.WriteLine(BigInteger.Pow(Int32.MaxValue,2));
            Console.WriteLine(b2==b3);
            Console.WriteLine(BigInteger.GreatestCommonDivisor(b1,b2));

            Console.WriteLine("i++ = {0}", i++); // The original value of i is displayed and then it is incremented to 1
            Console.WriteLine("++i = {0}", ++i); // Here the value of i is already incremented to 1 from previous line, and then it is incremented agian before being displayed

            int x = 20;
            int y = 10;

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("Relational Operators in C#");
            Console.WriteLine("Equals == : {0}", x==y);
            Console.WriteLine("Not Equals != : {0}", x != y);
            Console.WriteLine("Grater Than > : {0}", x > y);
            Console.WriteLine("Greater Than or Equals >= : {0}", x >= y);
            Console.WriteLine("Less Than < : {0}", x < y);
            Console.WriteLine("Less Than or Equals <= : {0}", x <= y);
            Console.WriteLine("Logical Operators in C#");
            Console.WriteLine("And (Conditional) && : {0}", (x==20) && (y==10));
            Console.WriteLine("And (Logical) & : {0}", (x == 20) & (y == 10));
            Console.WriteLine("Or (Conditional) || : {0}", (x == 20) || (y == 10));
            Console.WriteLine("Or (Logical) | : {0}", (x == 20) | (y == 10));
            Console.WriteLine("XOr : {0}", (x == 20) ^ (y == 10));

            // Ternary Operator
            object a = true ? (object)3 : (object)"yu";
            Console.WriteLine(a);
            string b = (x == 20) ^ (y == 10) ? (string)"yuyis" : (string)"yayis";
            Console.WriteLine(b);

            int? n = 10;
            int? c = null;
            string d = null;
            Console.WriteLine(c ?? -1); // writes the default (-1) if the variable c is null
            Console.WriteLine(n ?? -1); // writes the assigned value if the variable n has value
            Console.WriteLine(d ?? "Undefined by birlochas");
            Console.WriteLine("Getting the null value of {0}",c.GetValueOrDefault(-2)); 
            Console.WriteLine("c has a value? {0}", c.HasValue);
            n.GetValueOrDefault();
            Console.WriteLine(n);

            // Unboxing operations
            int? j = 36;
            object boxed = j;
            Console.WriteLine(j);
            Console.WriteLine(boxed);
            int k = (int) boxed;
            Console.WriteLine("incrementing boxed through explisit assingment: {0}", ++k);
            int? l = boxed as int?; // return the conversion or null if converson is unsuccessfull
            Console.WriteLine("incrementing boxed through an operator assingment: {0}", l+=1);

            try
            {
                int divisor = Convert.ToInt32(0);
                int result = 3 / divisor;
                Console.WriteLine("Result: {0}", result);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again using a no-zero divisor");
                throw e;
            }

        }
    }
}
