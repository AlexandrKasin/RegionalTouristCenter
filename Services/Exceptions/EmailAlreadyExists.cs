using System;

namespace Services.Exceptions
{
    public class EmailAlreadyExists : Exception
    {
        public EmailAlreadyExists()
        {
        }

        public EmailAlreadyExists(string message) : base(message)
        {
        }

        public EmailAlreadyExists(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}