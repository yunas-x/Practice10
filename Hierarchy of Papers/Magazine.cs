using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.Papers
{
    /// <summary>
    /// Журнал
    /// </summary>
    public class Magazine: Paper
    {
        public new void SomeMethod()
        {
            Console.WriteLine("I am Child");
        }

        public String Issuer { get; set; }

        /// <summary>
        /// Create a magazine
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        public Magazine(int number, string name) : base(number, name) { }

        /// <summary>
        /// Create a magazine
        /// </summary>
        /// <param name="number">Issue</param>
        /// <param name="name">Book title</param>
        /// <param name="issuer">Typography or company</param>
        public Magazine(int number, string name, string issuer) : base(number, name) 
        {
            Issuer = issuer;        
        }

        /// <summary>
        /// Depricated. Might raise errors
        /// </summary>
        [Obsolete]
        internal Magazine() : base() { }

        public override void SomeVirtualMethod()
        {
            Console.WriteLine("I am Child");
        }

        public override object Clone()
        {
            if (this.GetType() == typeof(Magazine))
                return new Paper(IssueNumber, Name);
            else
                throw new Exception("Overload this method for proper use");
        }
    }
}
