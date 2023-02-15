using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.Papers
{
    /// <summary>
    /// Книга
    /// </summary>
    public class Book : Paper
    {
        public new void SomeMethod()
        {
            Console.WriteLine("I am Child");
        }

        public string Author { get; private set; }

        /// <summary>
        /// Create a book
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        public Book(int number, string name) : base(number, name) { }

        /// <summary>
        /// Create a book
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        /// <param name="author">Book author</param>
        public Book(int number, string name, string author) : base(number, name) 
        {
            Author = author;
        }

        public bool HasAuthor()
        {
            return !String.IsNullOrWhiteSpace(Author);
        }

        /// <summary>
        /// Depricated. Might raise errors
        /// </summary>
        [Obsolete]
        internal Book() : base() { }

        public override void SomeVirtualMethod()
        {
            Console.WriteLine("I am Child");
        }

        public override object Clone()
        {
            if (this.GetType() == typeof(Book))
                return new Paper(IssueNumber, Name);
            else
                throw new Exception("Overload this method for proper use");
        }
    }
}
