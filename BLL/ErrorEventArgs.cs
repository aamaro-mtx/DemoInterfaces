using System;

namespace BLL
{
    public partial class Product
    {
        public class ErrorEventArgs : EventArgs
        {
            public ErrorEventArgs(string message)
            {
                Message = message;
            }
            public string Message { get; set; }
        }
    }
}
