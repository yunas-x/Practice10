using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.Papers
{
    /// <summary>
    /// Учебник
    /// </summary>
    public class StudentBook: Book
    {
        public new void SomeMethod()
        {
            Console.WriteLine("I am GrandChild");
        }

        public Subjects Subject { get; set; }

        /// <summary>
        /// Create a studentbook
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        public StudentBook(int number, string name) : base(number, name) { }

        /// <summary>
        /// Create a studentbook
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        /// <param name="author">Book author</param>
        public StudentBook(int number, string name, string author) : base(number, name, author) { }

        /// <summary>
        /// Create a studentbook
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        /// <param name="author">Book author</param>
        /// <param name="subject">Discipline or field of study</param>
        public StudentBook(int number, string name, string author, Subjects subject) : base(number, name, author) 
        {
            Subject = subject;
        }

        /// <summary>
        /// Depricated. Might raise errors
        /// </summary>
        [Obsolete]
        internal StudentBook() : base() { }

        public override void SomeVirtualMethod()
        {
            Console.WriteLine("I am GrandChild");
        }

        public override object Clone()
        {
            if (this.GetType() == typeof(StudentBook))
                return new Paper(IssueNumber, Name);
            else
                throw new Exception("Overload this method for proper use");
        }


        public enum Subjects
        {
            NoSubject = 0,
            English = 1,
            Algebra = 2,
            Calculus = 3,
            Russian = 4,
            Geometry = 5,
            CSharp = 6,
            History = 7,
            Economics = 8,
            Law = 9,
        }
    }
}
