using System;
namespace Yatter.Invigoration.TResponse
{
    public class TRFatalResponse : ITResponse
    {
        public string TResponseType { get; set; }
        public bool IsSuccess {  get; set; }
        public string Message { get; set; }

        public TRFatalResponse()
        {
            TResponseType = GetType().ToString();
            IsSuccess = false;
        }
    }
}
