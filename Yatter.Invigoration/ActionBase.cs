using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public abstract class ActionBase : IAction, IDisposable
    {
        private bool _isadded;

        public ObjectBase Object { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<ActionBase> NestedResponses = new List<ActionBase>();

        private List<object> Disposables = new List<object>(); 

        public virtual void Action() {}

#pragma warning disable CS1998
        public async virtual Task ActionAsync() {}
#pragma warning restore CS1998

        public void AddObject(ObjectBase @object)
        {
            Object = @object;
        }

        public virtual void AddDisposableObject(object @object)
        {
            Disposables.Add(@object);
        }

        public virtual void AddToNestedResponse()
        {
            if (!_isadded)
            {
                NestedResponses.Add(this);
                _isadded = true;
            }
        }

        public virtual void Dispose()
        {
            foreach (var item in Disposables)
            {
                try
                {
                    var disposable = (IDisposable)item;

                    disposable.Dispose();
                }
                catch(Exception ex)
                {
                    // fail gracefully
                }
            }
        }
    }
}
