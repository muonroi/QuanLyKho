using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyKhoUtilities.Exeptions
{
    public class QuanLyKhoException : Exception
    {
        public QuanLyKhoException()
        {
        }
        public QuanLyKhoException(string message)
            : base(message)
        {
        }

        public QuanLyKhoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
