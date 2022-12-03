using System;
using System.Text.RegularExpressions;

namespace Store.domain
{
    public class Book
    {
        public int Id { get; }
        public string Isbn { get; }
        public string Author { get; }
        public string Title { get; }

        public string Description { get; }
        public decimal Price { get; }//тип данных десимал используется для вывода цены, так как float или double имеют небольшую погрешность 
        public Book(int id,string isbn, string author, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            Author = author;
            Description = description;
            Price = price;
        }
        internal static bool IsIsbn(string s)
        {
            if (s == null)
            {
                return false;
            }
            s = s.Replace(" ", "");
            return Regex.IsMatch(s, @"Isbn\d{6}");
        }
    }
}
