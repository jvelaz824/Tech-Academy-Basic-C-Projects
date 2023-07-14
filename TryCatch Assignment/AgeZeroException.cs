using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    public class AgeZeroException : Exception //inherits from Exception class
    {

        public AgeZeroException() //AgeZeroException uses body of Exception class
            : base() { }
        public AgeZeroException(string message) //AgeZeroException uses body of Exception class with one string parameter
            : base(message) { }

    }
}
