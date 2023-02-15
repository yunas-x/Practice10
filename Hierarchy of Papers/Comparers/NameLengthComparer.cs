using Practice_10_Example.Papers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice_10_Example.Papers.Comparers
{
    /// <summary>
    /// Compares Papers by name length
    /// </summary>
    public class NameLengthComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var _x = x as Paper;
            var _y = y as Paper;

            if (_x != null && _y != null)
                return _x.Name.Trim().Length - _y.Name.Trim().Length;

            else return Int32.MaxValue;
        }
    }
}
