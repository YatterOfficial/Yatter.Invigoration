using System;
namespace Yatter.Invigoration.Exceptions
{
    public class TActorNotImplementedException : Exception
    {
        public new string Message { get; set; }

        public TActorNotImplementedException(string tActorType)
        {
            Message = $"Exception: {tActorType} has not been implemented.";
        }
    }
}
