using System;
namespace Yatter.Invigoration.TResponse
{
    public interface ITResponse
    {
        string TResponseType { get; set; }
        bool IsSuccess { get; set; }
        string Message { get; set; }
    }
}
