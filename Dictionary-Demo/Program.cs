using System;
using System.Collections.Generic;

namespace Dictionary_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();  // <tipo da chave, tipo de valor>
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99771122";             //não deixa sobrepor valores imprime o segundo valor
            cookies["phone"] = "99771133";
            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");
            Console.WriteLine("Phone number: " + cookies["phone"]);
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine("Email: " + cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is not 'email' key");
            }
            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
