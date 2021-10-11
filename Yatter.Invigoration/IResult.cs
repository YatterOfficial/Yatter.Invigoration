using System;
using System.Collections.Generic;

namespace Yatter.Invigoration
{
    public interface IResult : IOutcome
    {
        string TActorType { get; set; }
        object Response { get; set; }
        List<Result> NestedResults { get; set; }
        Type GetResponseType();
    }
}