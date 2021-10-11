using System;
namespace Yatter.Invigoration
{
    public interface IObject : IActions
    {
        public void AddActor(IActions tActor);
    }
}
