using System;
namespace Yatter.Invigoration
{
    public abstract class ObjectBase
    {
        [Newtonsoft.Json.JsonIgnore]
        public IAction Actor { get; set; }

        public void AddActor(IAction actor)
        {
            Actor = actor;
        }

        public abstract void Act();
    }
}
