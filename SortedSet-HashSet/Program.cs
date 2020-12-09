using SortedSet_HashSet.Entities;
using System;
using System.Collections.Generic;

namespace SortedSet_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {

            //HashSet
            //HashSet<string> set = new HashSet<string>();
            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");
            //Console.WriteLine(set.Contains("Notebook"));
            //foreach (String p in set)   //não existe for para conjuntos
            //{
            //    Console.WriteLine(p);
            //}
            //_____________________________________________________________________
            //    //SortedSet
            //    SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };  //mantem a ordem sempre
            //    SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            //    //union
            //    SortedSet<int> c = new SortedSet<int>(a);
            //    c.UnionWith(b);
            //    printCollection(c);
            //    //intersection
            //    SortedSet<int> d = new SortedSet<int>(a);
            //    d.IntersectWith(b);
            //    printCollection(d);
            //    //difference
            //    SortedSet<int> e = new SortedSet<int>(a);
            //    e.ExceptWith(b);
            //    printCollection(e);
            //}
            //static void printCollection<T>(IEnumerable<T> collection) //recebe como argumento um IEnumerable T collection
            //{
            //    foreach (T obj in collection)
            //    {
            //        Console.Write(obj + " ");
            //    }
            //    Console.WriteLine();
            //___________________________________________________________________________
            //Hash testando igualdade

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));  // se dentro do conjunto a contem o objeto prod? mesmo sendo igual a descrição não contém, a não ser que a classe esteja especificando.

            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point)); //quando o tipo é struck ele compara por conteúdo e não por referência




        }
    }
}
