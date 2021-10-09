using System;
using System.Threading.Tasks;

namespace Yatter.Invigoration
{
    public class Invigorator
    {
        public static TActor Act<TObject, TActor>()
        where TObject : ObjectBase, new()
        where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = new TObject();

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            tActor.Action();

            return tActor;
        }

        public static TActor Act<TObject, TActor>(string json)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject>(json);

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            tActor.Action();

            return tActor;
        }

        public static TActor Act<TObject, TActor>(TObject @object)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = @object;

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            tActor.Action();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>()
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = new TObject();

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(string json)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject>(json);

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(TObject @object)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = @object;

            TActor tActor = default(TActor);
            tActor = new TActor();
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(TActor actor)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = new TObject();

            TActor tActor = default(TActor);
            tActor = actor;

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(ActionBase actor)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = new TObject();


            tObject.AddActor(actor);

            await actor.ActionAsync();

            return (TActor)actor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(string json, TActor actor)
        where TObject : ObjectBase, new()
        where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject>(json);

            TActor tActor = default(TActor);
            tActor = actor;
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

        public async static Task<TActor> ActAsync<TObject, TActor>(TObject @object, TActor actor)
            where TObject : ObjectBase, new()
            where TActor : ActionBase, new()
        {
            TObject tObject = default(TObject);
            tObject = @object;

            TActor tActor = default(TActor);
            tActor = actor;
            tActor.AddObject(tObject);

            tObject.AddActor((IAction)tActor);

            await tActor.ActionAsync();

            return tActor;
        }

    }
}
