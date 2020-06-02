using System;

namespace Animals
{
    public class CustomException : Exception
    {
        public override string Message => "Invalid input!";
    }
}
