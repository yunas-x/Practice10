using Practice_10_Example.RandomInit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.SimpleClasses
{
    /// <summary>
    /// First class
    /// </summary>
    public class MyFirstClass: IRandomInit
    {
        /// <summary>
        /// Simple method (always treats entity as MyFirstClass)
        /// </summary>
        /// <returns>true if entity is MyFirstClass</returns>
        public bool IAmFirstClass()
        {
            return true;
        }

        /// <summary>
        /// Virtual one (treats entity as it is)
        /// </summary>
        /// <returns>true if MyFirstClass</returns>
        public virtual bool IAmVirtuallyFirstClass()
        {
            return true;
        }

        /// <summary>
        /// For random init only
        /// </summary>
        protected bool initialized = false;

        public void RandomInit() 
        {
            initialized = true;
        }

    }

    /// <summary>
    /// Second class
    /// </summary>
    public class MySecondClass : MyFirstClass
    {
        /// <summary>
        /// Look above
        /// </summary>
        /// <returns>Look above</returns>
        public new bool IAmFirstClass()
        {
            return false;
        }

        // Saves summary
        public override bool IAmVirtuallyFirstClass()
        {
            return false;
        }
    }
}
