using System;
namespace Yatter.Invigoration
{
    public interface IObject : IAction
    {
        public void AddActor(IAction printer);
    }
}
