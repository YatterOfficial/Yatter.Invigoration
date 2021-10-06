using System;
namespace Yatter.Invigoration
{
    public abstract class ActionBase : IAction
    {
        public ObjectBase Object { get; set; }

        public abstract void Action();

        public void AddObject(ObjectBase @object)
        {
            Object = @object;
        }
    }
}
