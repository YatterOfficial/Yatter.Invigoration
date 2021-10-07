using System;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public interface IAction
    {
        public void Action();
        public Task ActionAsync();
    }
}
