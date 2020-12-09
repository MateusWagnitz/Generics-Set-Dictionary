using Equals_GetHashCode.Entities;
using System;

namespace Equals_GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equals
            //string a = "Maria";
            //string b = "Alex";
            //Console.WriteLine(a.Equals(b));

            //GetHashCode
            //string a = "Maria";
            //string b = "Alex";
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


        }
    }
}
