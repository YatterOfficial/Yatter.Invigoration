using System;
namespace Yatter.Invigoration
{
    public interface IOutcome
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
    }
}
