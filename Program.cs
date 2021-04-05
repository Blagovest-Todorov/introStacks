using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();
            books.Push("Pinokio"); // 1
            books.Push("War and Peace"); // 2
            books.Push("The Alchemist"); // 3

            Console.WriteLine(books.Count);
            Console.WriteLine(books.Pop());
            Console.WriteLine(books.Count);
            Console.WriteLine(books.Pop());

            books.Push("War and Peace");
            Console.WriteLine(books.Pop());

            Console.WriteLine(books.Peek());
            Console.WriteLine(books.Peek());
            Console.WriteLine(books.Peek());
        }
    }
}
