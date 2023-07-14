using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    public class AgeNegativeException : Exception //inherits from Exception class
    {
        public AgeNegativeException() // AgeNegativeException uses body of Exception class 
            : base() { }
        public AgeNegativeException(string message) // AgeNegativeException uses body of Exception class with one string parameter
            : base(message) { }
    }
}
