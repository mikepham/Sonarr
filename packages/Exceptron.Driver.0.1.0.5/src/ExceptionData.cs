using System;

namespace Exceptron.Driver
{
    public class ExceptionData
    {
        public Exception Exception { get; set; }
        public string Location { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
    }
}