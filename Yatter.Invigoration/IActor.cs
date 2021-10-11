using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    /// <summary>
    /// The extracted interface of ActionBase
    /// </summary>
    public interface IActor : IOutcome
    {
        ObjectBase Object { get; set; }
        string TActorType { get; set; }
        object Response { get; set; }
        Result Result { get; }

        void Action();
        Task ActionAsync();
        void AddChildToNestedResponse(Result result);
        void AddDisposableObject(object @object);
        void AddObject(ObjectBase @object);
        void Dispose();
    }
}