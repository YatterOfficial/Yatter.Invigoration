using System;
namespace Yatter.Invigoration.TResponse
{
    public class TRNotImplemented : ITResponse
    {
        public string TResponseType { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public TRNotImplemented()
        {
            TResponseType = GetType().ToString();
        }
    }
}
