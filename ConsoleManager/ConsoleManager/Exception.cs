using System;
namespace ConsoleManager
{
    public class Exception:ApplicationException
    {
        public Exception(string message):base(message)
        {
        }
    }
}
