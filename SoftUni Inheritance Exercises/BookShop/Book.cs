using System;
using System.Linq;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;
        public string Author
        {
            get => author;
            private set
            {
                string[] names = value.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                author = value;
            }
        }
        public string Title
        {
            get => title;
            private set
            {
                if (value.Length < 3 || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title not valid!");
                title = value;
            }
        }
        public virtual decimal Price
        {
            get => price;
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");
                price = value;
            }
        }
        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {GetType().Name}")
                .AppendLine($"Title: {Title}")
                .AppendLine($"Author: {Author}")
                .AppendLine($"Price: {Price:F2}");
            return resultBuilder.ToString().TrimEnd();
        }
    }
}
