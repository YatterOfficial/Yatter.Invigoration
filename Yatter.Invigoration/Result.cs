using System;
using System.Collections.Generic;

namespace Yatter.Invigoration
{
    public class Result : IResult
    {
        public string TActorType { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }
        public List<Result> NestedResults { get; set; }

        public Type GetResponseType()
        {
            if (Response != null)
            {
                return Response.GetType();
            }

            return default(Type);
        }
    }
}
