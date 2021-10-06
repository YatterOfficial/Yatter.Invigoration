using System;
namespace Yatter.Invigoration
{
    public class Invigorator
    {
        public static void Act<TObject, TActor>(string json)
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
        }

        public static void Act<TObject, TActor>(TObject @object)
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
        }
    }
}
