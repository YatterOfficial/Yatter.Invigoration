using System;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public abstract class ObjectBase : IDisposable
    {
        [Newtonsoft.Json.JsonIgnore]
        public IAction Actor { get; set; }

        public void AddActor(IAction actor)
        {
            Actor = actor;
        }

        public virtual void Act() {
            Actor.Action();
        }

#pragma warning disable CS1998
        public async virtual Task ActAsync() {

            await Actor.ActionAsync();
        }
#pragma warning restore CS1998

        public virtual void Dispose() { }
    }
}
