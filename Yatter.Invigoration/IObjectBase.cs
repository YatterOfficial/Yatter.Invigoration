using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public interface IObjectBase
    {
        IActions Actor { get; set; }

        void Act();
        Task ActAsync();
        void AddActor(IActions actor);
        void Dispose();
    }
}