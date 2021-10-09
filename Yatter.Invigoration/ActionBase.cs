using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public abstract class ActionBase : IAction, IDisposable
    {
        
        /// <summary>
        /// The original TObject
        /// </summary>
        public ObjectBase Object
        {
            get;
            set;
        }

        public string TActorType {  get; set; }
        /// <summary>
        /// Was the Action a Success?
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// What message is associated with the result of the action? 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The Response object
        /// </summary>
        public Object Response { get; set; }

        /// <summary>
        /// The Result, returning a copy of IsSuccess, Message, and Response
        /// </summary>
        public Result Result
        {
            get
            {
                return new Result { TActorType = TActorType, IsSuccess = IsSuccess, Message = Message, Response = Response, NestedResults = NestedResults };
            }
        }

        public List<Result> NestedResults = new List<Result>();

        public void AddChildToNestedResponse(Result result)
        {
            NestedResults.Add(result);
        }

        /// <summary>
        /// A List of nested Objects from previous Invigorations. Includes the TObject from this Invigoration if IsAddedToObjectNest = true.
        /// </summary>
        public List<object> NestedObjects = new List<object>();

        /// <summary>
        /// A list of IDisposable objects to be disposed of when this object is disposed of.
        /// </summary>
        private List<object> Disposables = new List<object>(); 

        /// <summary>
        /// The synchronous Action to be undertaken by the TActor, only called by the Invigorator if it's trammel is Invigorator.Act<TObject,TActor>(...)
        /// </summary>
        public virtual void Action() {}

#pragma warning disable CS1998
        /// <summary>
        /// The asynchronous Action to be undertaken by the TActor, only called by the Invigorator if it's trammel is Invigorator.ActAsync<TObject,TActor>(...)
        /// </summary>
        /// <returns></returns>
        public async virtual Task ActionAsync() {}
#pragma warning restore CS1998

        /// <summary>
        /// Adds the TObject to the TActor
        /// </summary>
        /// <param name="object">A TObject that inherits ObjectBase</param>
        public void AddObject(ObjectBase @object)
        {
            Object = @object;
        }

        /// <summary>
        /// Adds an IDisposable object to the List of IDisposable objects that will be disposed of when this object is disposed of.
        /// </summary>
        /// <param name="object">An object that inherits from IDisposable</param>
        public virtual void AddDisposableObject(object @object)
        {
            Disposables.Add(@object);
        }

        /// <summary>
        /// The IDisposable function that is called when this object is being disposed of.
        /// </summary>
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
