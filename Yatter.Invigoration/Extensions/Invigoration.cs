using System;
using System.Threading.Tasks;

namespace Yatter.Invigoration.Extensions
{
    public static class Invigoration
    {
        public static ActionBase AddTObjectToTActor(this ActionBase tActor, ObjectBase tObject)
        {
            tActor.AddObject(tObject);

            return tActor;
        }

        public static TActor AddTObjectToTActor<TActor>(this ActionBase tActor, ObjectBase tObject) where TActor : ActionBase, new()
        {
            tActor.AddObject(tObject);

            return (TActor)tActor;
        }

        public static TActor Invigorate<TActor>(this ObjectBase tObject) where TActor : ActionBase, new()
        {
            TActor tActor = (default);
            tActor = new TActor();

            tActor.AddObject(tObject);

            tActor.Action();

            return (TActor)tActor;
        }

        public async static Task<TActor> InvigorateAsync<TActor>(this ObjectBase tObject) where TActor : ActionBase, new()
        {
            TActor tActor = (default);
            tActor = new TActor();

            tActor.AddObject(tObject);

            await tActor.ActionAsync();

            return (TActor)tActor;
        }
    }
}
