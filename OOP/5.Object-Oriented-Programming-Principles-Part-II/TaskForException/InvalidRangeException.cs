/* -----------------------------------------------------------------------
Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
It should hold error message and a range definition [start … end].

// -----------------------------------------------------------------------*/

namespace TaskForException
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        //fields and properties
        public T Start { get; set; }
        public T End { get; set; }
        //constructor
        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
