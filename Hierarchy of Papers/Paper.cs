using Practice_10_Example.RandomInit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.Papers
{
    /// <summary>
    /// Печатное издание
    /// </summary>
    public class Paper: IComparable, ICloneable, IRandomInit
    {

        protected static int _count = 0;

        /// <summary>
        /// Get number of papers issued
        /// </summary>
        /// <returns>Number of papers</returns>
        public static int GetPaperCount()
        {
            return _count;
        }
            
        private int number;

        /// <summary>
        /// Number of paper issue
        /// </summary>
        public int IssueNumber
        {
            get => number;
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Ноль нельзя");
                else number = value;
            }
        }

        /// <summary>
        /// Name of a paper (could be unnamed)
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Create a paper
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        public Paper(int number, string name)
        {
            _count++;
            IssueNumber = number;
            Name = name;
        }

        /// <summary>
        /// Depricated. Might raise errors
        /// </summary>
        [Obsolete("Raises error on Cloning")]
        internal Paper() 
        { 
            _count++; 
        }

        /// <summary>
        /// Prints "I am Parent" if invoked by Paper class object. Not virtual
        /// </summary>
        public void SomeMethod()
        {
            Console.WriteLine("I am Parent");
        }

        /// <summary>
        /// Prints "I am Parent" if invoked by Paper class object. Virtual
        /// </summary>
        public virtual void SomeVirtualMethod()
        {
            Console.WriteLine("I am Parent");
        }

        /// <summary>
        /// Is issue number even
        /// </summary>
        /// <returns>True if even, false otherwise</returns>
        public bool IsIssueNumberEven()
        {
            return number % 2 == 0 ? true : false;
        }

        /// <summary>
        /// Defines if paper is named
        /// </summary>
        /// <returns>True if paper name is not null or whitespace-only, otherwise false</returns>
        public bool IsPaperNamed()
        {
            return !String.IsNullOrWhiteSpace(Name);
        }

        public override string ToString()
        {
            if (Name == null || IssueNumber == 0)
                return "Object is depricated or broke";

            return $"{Name}: №{IssueNumber}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Paper)
                return IssueNumber.CompareTo(((Paper)obj).IssueNumber);
            else
                throw new ArgumentException("Object is incomparable");
        }

        public virtual object Clone()
        {
            if (this.GetType() == typeof(Paper))
                return new Paper(IssueNumber, Name);
            else
                throw new Exception("Overload this method for proper use");
        }

        /// <summary>
        /// Creates a copy
        /// </summary>
        /// <returns>A shallow copy</returns>
        public virtual Paper ShallowCopy()
        {
            return (Paper)MemberwiseClone();
        }

        // You may override this yourself
        public virtual void RandomInit()
        {
            Random rnd = new Random();

            IssueNumber = rnd.Next(1, 100);
            Name = $"Random Create {nameResourse[rnd.Next(0, 3)]}";
        }

        private static string[] nameResourse = {"HSE Daily", "PSU Daily", "StackOverflow"};

        // Override other object-inherited methods by yourself
    }
}
