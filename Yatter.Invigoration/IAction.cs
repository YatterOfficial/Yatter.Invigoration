using System;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public interface IActions
    {
        public void Action();
        public Task ActionAsync();
    }
}
