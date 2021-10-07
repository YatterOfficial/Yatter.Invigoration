## Yatter.Invigoration

# Invigoration Pattern a.k.a The Invigorator's Trammel

_If Tetris was applied to Software Engineering, it would be about the Invigoration Model:_

- A series of pre-existing shapes are subjected to being dynamically arranged by a pack-and-place management tool which allows individual shapes to be placed subject to the arrangement of those shapes that have preceded them; paralellism is achieved by the same game being played in parallel, with fanning in being represented by the accumulated scores of each of the games complementing the benefits of the existential arrangement patterns of each game.

Invigoration is particularly suited to being utilised within a host of existing design patterns and in being so are minutiae that can be shaped into any arrangement to represent any of these patterns.

If the art of design was a sand-castle competition, then all the shapes are best represented when the grains of sand are the invigorators that are the basic building block of the Invigoration Pattern.

_In such a case, the 'Sand Castle Competition' is the ubiquitous app-store!_

## Benefits

### Examples

*Invigorators* can be arranged to:

- be encapsulted to achieve Composite pattern
- be collectively deployed to achieve Facade pattern
- be lineally ordered to achive Adapter pattern
- be dynamically selected to achieve Factory pattern
- differentiate between objects, and the actions that objects are subject to

*Invigorators* are particularly useful when:

- they are orchestrated within Azure's Dynamic Functions to take single steps inputs, supplying those single step outputs, each in a single line of code
- they are numerously encapsulated using Composite Pattern into single Facades that can be deployed in any of a variety of contexts and environments
- they prevail as single line-of-code in anything from an app that glows in front of a user's face, to single line-of-code in an HttpTrigger Function, MVC Controller, or Worker in the cloud, where that line-of-code is merely a pixel in the data-scientist's mind's eye of the whole composite world-wide data-traffic-route fly-ways that can wholly be seen in the data-scientist's imagination of the data-luminescent night-sky
- it is desired to efficiently arrange functionality into ordered matrices of TObjects and TActor
- software engineer's, seeing the word _Invigorator.Act..._ in a line of code, will immediately know it's inner structure - who will thus more readily adapt to being introduced to an existing code-base - who will then also know approximately where to easily find the invigorated matrices of TObjects and TActors, in the code-base, no matter how convoluted the actual applications workflows are
- TObject and TActor matrices are essentially a look-up spreadsheet of the capability of an application
- Invigorators are nested, rendering a lot of work in a single line, with the decisions that relate to the output of one, being handled by the input of the nesting Invigorator; as such, Nested Invigorators remove the code-clutter of decisions that need to be made about their return values


## Definitions

### INVIGORATION

- 'Invigoration' is "the activity of giving vitality and vigour to something", which in the Software Engineering sense, is achieved by an Actor causing an Action to be undertaken upon an Object; this is phrased using generics as TActors causing Acts upon TObjects
  
### INVIGORATION PATTERN / INVIGORATOR'S TRAMMEL

- An 'Invigoration Pattern', also known as an 'Invigorator's Trammel', is a statement that defines the relationship of an Object with it's Actor, within the constraints of the Trammel.
  
### INVIGORATOR

- An 'Invigorator' is "an agent that gives or restores life or vigor", which in the Software Engineering sense, is the mechanism that exposes the channel of the invigoration trammel (it's freedoms), as well as it's constraints.
  
### TRAMMEL

- A 'Trammel' (noun) is defined as "restrictions or impediments to freedom of action.", with 'freedom within the channel of the trammel' implied to exist by the very nature of the constraints.
- Using Generics, the 'T' of Trammel is represented as the T of TObject and the T of TActors
- TObject and TActor are pronounced tob-ject and tac-tor, respectively ~ tob and tac for short
- A pictorial grasp of how a trammel can dynamically convert singular TObjects and TActors into a range of dynamic opportunities, can be obtained by looking at videos on YouTube about [The Trammel of Archimedes](https://www.youtube.com/results?search_query=archimedes+Trammel). The most basic representation is the one at [this](https://youtu.be/7Fn-26Jmi5E?t=46) timecode - thanks Mathologer - where each of the two axis can be seen to represent a generics TObject and TActor, respectively. Adding TObjects and TActors just adds to the axis, as seen in the other videos.
- When a Software Engineer sees an Invigorator in a line-of-code, then because he knows that an Invigorator's signature is based upon TObjects and TActors, then his knowing that a Trammel-T represents the base-class of each, he immediately knows where to find the Object that is acted upon, or the Action that the Actor effects upon the Object 

16 Invigorator Trammel-Couplets are possible, each illustrated below, of which the first 15 can be derived by removing all of the exposed permutations, or by the synchronous reduction, of the 16th:

vis-a-vis:

```
Invigorator.Act<TObject,TActor>();
Invigorator.Act<TObject,TActor>(TObject @object);
Invigorator.Act<TObject,TActor>(TActor actor);
Invigorator.Act<TObject,TActor>(TObject @object, TActor actor);

TActor acted = Invigorator.Act<TObject,TActor>();
TActor acted = Invigorator.Act<TObject,TActor>(TObject @object);
TActor acted = Invigorator.Act<TObject,TActor>(TActor actor);
TActor acted = Invigorator.Act<TObject,TActor>(TObject @object, TActor actor);

await Invigorator.ActAsync<TObject,TActor>();
await Invigorator.ActAsync<TObject,TActor>(TObject @object);
await Invigorator.ActAsync<TObject,TActor>(TActor actor);
await Invigorator.ActAsync<TObject,TActor>(TObject @object, TActor actor);

TActor acted = await Invigorator.ActAsync<TObject,TActor>();
TActor acted = await Invigorator.ActAsync<TObject,TActor>(TObject @object);
TActor acted = await Invigorator.ActAsync<TObject,TActor>(TActor actor);
TActor acted = await Invigorator.ActAsync<TObject,TActor>(TObject @object, TActor actor);
```

Example:

```
...
carActor.Add([any objects that the actor needs to act upon the car]); // pseudocode
...
CarActor acted = await Invigorator.ActAsync<Car,CarActor>(carActor); // or (car, carActor)
...
var success = acted.IsSuccess;
...
var failureMessage = acted.Message;
...
var modifiedCar = acted.Car;
...
```

Note: Invigorators can be chained such that the success or failure is managed in the next link in the chain.

```
CarActor carActed = await Invigorator.ActAsync<Car,CarActor>(carActor);

MechanicActor mechanicalActed = await Invigorator.ActAsync<WorkTicket,MechanicActor>(carActed.MechanicActor);
```

or quite simply:

```
MechanicActor mechanicActed = await Invigorator.ActAsync<WorkTicket,MechanicActor>(
                                await Invigorator.ActAsync<Car,CarActor>(carActor));
```
Note that the signature implies that there MUST be an MechanicActor available to the second invigorator, in the output of the first!

Of course, the above could be further nested - with the same outputs also inferred by the signature - so it is easy to also see the benefits of chaining the IsSuccess and Message properties, of each.

For example:

```
BillingActor billingActed = Invigorator.ActAsync<PrePaymentAuthorization,BillingActor>(
                      await Invigorator.ActAsync<WorkTicket,MechanicActor>(
                      await Invigorator.ActAsync<Car,CarActor>(carActor)));
...
if(!billingActed.IsSuccess)
{
  Console.WriteLine(billingActed.Message);
}
...
```
where the output might be: "Payment cannot be be pre-authorised because the MechanicActor has identified that there are not any parts available, hence the work cannot be scheduled."

This message may have been composed from:

- the MechanicActor Message, which would have read "MechanicActor has identified that there are not any parts available, hence the work cannot be scheduled"
- the BillingActor Message, which would have read "Payment cannot be pre-authorised because the {mechanicActed.Message}."

Alternatively, the BillingActor might have queried the ```mechanicActed.NestedResponses``` list, where each of the previous actors had added itself to the list so that the next one could copy it, add itself, and pass it on. Although this is an advanced topic, the final actor merely needs to iterate through this list to find where the first ```IsSuccess=false``` occurred, and react accordingly.

This example does, however, illustrate the simple Invigoration behind a user pressing a submit button on a car servicing website: all the Invigoration happens in a single line of nested code that is easily assembled, readily readable, and easily understood and located in the TObject / TActor matrix.

#### Trammel Summary

- Objects (```TObject```) to be acted upon by an Actor (```TActor```) are confined to one of 16 ```Invigorator Trammel Couplets``` where the most exposed of the 16 trammels is:
    - ```TActor acted = await Invigorator.ActAsync<TObject,TActor>(TObject @object, TActor actor);```
- The other 15 can be cascaded down to ```Invigorator.Act<TObject,TActor>();``` by removing all of the exposed permutations, or by synchronous reduction.
- All 16 are illustrated above.
- In the science of Invigoration, the `T` in `TObject` and `TActor` stands for _trammel_, where ```TObject``` and ```TActor``` are pronounced ```tob-ject``` and ```tac-tor```, _tob and tac for short_, respectively.

### A Coded Example

#### Car, an example of TObject

We will start with the contrived TObject of a Car.

Other than the trammel structure that is forced upon it by the ObjectBase, Car looks just like an ordinary DTO:

```
public class Car : Yatter.Invigoration.ObjectBase
{
    public Car()
    {
        DataType = "Car";
    }
    public string DataType { get; set; }
    public string Make { get; set; }
    public string Color { get; set; }
    public string Registration { get; set; }
    public string Base64Image { get; set;}
   
    public override void Dispose()
    {
        // Nothing to dispose of but if there was, we'd do it here!
    }
}
```

As Car is a trammel of TObject, it inherits from ObjectBase:

```
    public abstract class ObjectBase : IDisposable
    {
        [Newtonsoft.Json.JsonIgnore]
        public IAction Actor { get; set; }

        public void AddActor(IAction actor)
        {
            Actor = actor;
        }

        public virtual void Act() 
        {
            Actor.Action();
        }

        public async virtual Task ActAsync() 
        {

            await Actor.ActionAsync();
        }

        public virtual void Dispose() { }
    }
```

#### An introduction to the ObjectBase

The Car class above has three overrides available to it, which are exposed by the ```ObjectBase```:

- ```public virtual void Act() { }```
- ```public async virtual Task ActAsync() { }```
- ```public virtual void Dispose() { }```

_The choice of which to override, depends upon whether actions upon it are to be asynchronous, or not, and whether there will be anything to dispose when the object is destroyed._

The ```Actor``` is also exposed in the ```ObjectBase``` class, which is added by the ```Invigorator```.

#### CarActor, an example of TActor

We will start with the contrived TActor of a CarActor.

Other than the trammel structure that is forced upon it by the ActionBase, CarActor looks just like an ordinary object that does something to a DTO.

Indeed, this TActor was designed to be used inside a .NET Interactive Notebook, which fetches a Car JSON data object from a remote server, and then prints out HTML using PocketView (namespace Microsoft.DotNet.Interactive.Formatting.PocketViewTags).

How the IResponsiveHttpClient client works is not in the scope of this tutorial, however it is demonstrated [here](https://github.com/HarrisonOfTheNorth/Yatter-Demo-ResponsiveHttpClient).

CarActor is quite a simple object - all of the salient actions are undertaken in the ActionAsync() method - and yet it's underlying TActor trammel structure as is attributed by the ActionBase, is understood by the omnipotent Invigorator class.

```
class CarActor : Yatter.Invigoration.ActionBase
{
    public Car Car { get { return (Car)base.Object; } }
    public string Path { get; set; }
    
    public CarActor() {}

    public async override Task ActionAsync()
    {
        Yatter.Http.Clients.IResponsiveHttpClient client = new Yatter.Http.Clients.ResponsiveHttpClient();
    
        CarResponse response = await client.GetAsync<CarResponse, CarRequest>(new CarRequest() { Path = Path });
        
        base.IsSuccess = response.IsSuccess; // Important! Cascade 'response' Errors this way!
        base.Message = response.Message;     // Important! Cascade 'response' Messages this way!
        
        bool success = false;
        
        if (response != null) { success = response.IsSuccess; }

        if (success&&response!=null&&response.Car!=null)
        {
            try
            {
                // 1. Deserialise the response
                Car car = Newtonsoft.Json.JsonConvert.DeserializeObject<Car>(response.CarJson);

                // 2. Do something with that result   
                PocketView textview = span[style:"color:blue"]($"Car: {car.Make}, {car.Color}, {car.Registration}");
                textview.Display("text/html");

                PocketView imageview = span(img[src:$"data:image/jpeg;base64,{car.Base64Image}"]);
                imageview.Display("text/html");

                // 3. Assign the return base.Object
                base.Object = car; /* This is important, if you want access to the base Object, see the 
                declaration for the Car property, above. */
            }
            catch(Exception ex)
            {
                base.IsSuccess = false;    // Important! Cascade 'catch' Errors this way!
                base.Message = ex.Message; // Important! Cascade 'catch' Messages this way!
            }
        }
        base.AddToNestedResponse(); // Important! This is the LAST thing that must be done!
    }
    
    public override void Dispose()
    {
        ((Car)base.Object).Dispose();
    }
}
```

#### An introduction to the ActionBase

The CarActor class above has four available overrides, which are exposed by the ActionBase:

- ```public virtual void Action() {}```
- ```public async virtual Task ActionAsync() {}```
- ```public virtual void Dispose() { }```
- ```public virtual void AddToNestedResponse()```

_The choice of which to override, depends upon whether actions upon it are to be asynchronous, or not, and whether there will be anything to dispose when the object is destroyed._ The fourth, ```AddToNestedResponse()```, is about the advanced topic of _Invigoration Nesting_, which is introduced shortly.

- ALL the work is done in one of the Action methods - or any additional method that you write in support of which one you choose.

ActionBase also exposes a method of passing the Object to the Actor so that action can be done upon it:

```
public void AddObject(ObjectBase @object)
{
    Object = @object;
}
```

As well as exposing five properties:

- ```public ObjectBase Object { get; set; }``` - exposes the TObject being acted upon
- ```public bool IsSuccess { get; set; }``` - exposes if the Action was a success
- ```public string Message { get; set; }``` - exposes a message explaining why not a success
- ```public List<ActionBase> NestedResponses = new List<ActionBase>();``` - see below
- ```public bool IsAddedToNest { get; set; }``` - see below

Although Invigoration Nesting is an advanced topic, the last two enables any Invigorator to cycle through the results of the preceding Invigorations. 

Hence, there is also a method in the ActionBase that allows a TActor to add itself to the NestedResponses list so that a later TActor can interrogate it.

We will nest some Invigorators later on, to illustrate the benefit of nesting the responses.

```
public virtual void AddToNestedResponse()
{
    if (!IsAddedToNest)
    {
        NestedResponses.Add(this);
        IsAddedToNest = true;
    }
}
```

Note that the property ```IsAddedToNest``` is public and not private. This is so that TActors, if properly coded, can also be deserialised for transmission over a connection to another microservice. (Not all Invigorators will be portable in this matter, and the topic of Invigorator Portability, is not just a very advanced topic, but it comes with it's own unique set of deserialization challenges.)

And lastly, ActionBase exposes a method to add any other IDisposableObject to it, that you would wish, that is to be disposed of when the Actor is disposed of:

```
public virtual void AddDisposableObject(object @object)
{
    Disposables.Add(@object);
}
```
The ActionBase, as described, is as follows:

```
  public abstract class ActionBase : IAction, IDisposable
  {


      public ObjectBase Object { get; set; }
      public bool IsSuccess { get; set; }
      public string Message { get; set; }
      public List<ActionBase> NestedResponses = new List<ActionBase>();
      public bool IsAddedToNest { get; set; }

      private List<object> Disposables = new List<object>(); 

      public virtual void Action() {}

      public async virtual Task ActionAsync() {}

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
          if (!IsAddedToNest)
          {
              NestedResponses.Add(this);
              IsAddedToNest = true;
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
```

### TObject and TActor Invigoration

The capacity of both TObject and TActor to cohesively exist is enabled by the Invigorator, which the following example illustrates:

```
using(CarActor carActor = new CarActor()) // Both ObjectBase and ActionBase inherit from IDisposable
{
    Car car = null;
    
    carActor.Path = "buycar.json";

    CarActor acted = await Yatter.Invigoration.Invigorator.ActAsync<Car,CarActor>(carActor);
    
    carActor.AddDisposableObject(acted);

    car = acted.Car;

    if(acted.IsSuccess)
    {
        if(acted!=null&&acted.Car!=null&&acted.Car.Registration!=null)
        {
            PocketView hereareyourcarkeys = span[style:"color:purple"]($"Here are your keys to {car.Registration}!");
            hereareyourcarkeys.Display("text/html");
        }
        else
        {
            PocketView wevelostyourcarkeys = span[style:"color:purple"]("We've lost your car keys!");
            wevelostyourcarkeys.Display("text/html");
        }
    }
    else
    {
        PocketView wevelostyourcarkeys = span[style:"color:purple"](@"We've not just lost your car keys, 
                                                                    but we've lost the whole car as well!");
        wevelostyourcarkeys.Display("text/html");    

        if(!string.IsNullOrEmpty(acted.Message))
        {
            PocketView technicalError = span[style:"color:red"]($"Technical Error: {acted.Message}");
            technicalError.Display("text/html");    
        }
    }
    
    // Car is automatically disposed of when CarActor is disposed of, see each one's Dispose() override.
}
```

The previous nested example might look like this:

```
using(CarActor carActor = new CarActor())
{
  carActor.Path = "cars/W123ABC"; // pseudocode that illustrates the capacity to acquire a Car object
  
  BillingActor billingActed = Invigorator.ActAsync<PrePaymentAuthorization,BillingActor>(
                        await Invigorator.ActAsync<WorkTicket,MechanicActor>(
                        await Invigorator.ActAsync<Car,CarActor>(carActor)));
  if(!billingActed.IsSuccess)
  {
    Console.WriteLine(billingActed.Message);
  }
  else
  {
    //  do something with billingActed
  }
}
```

You can imagine that before this was called, that a user had added a work-ticket request to another system, prior to this being called, and that the MechanicActor knew where to get the WorkTicket request from, based upon the identity of the Car that was initially supplied to CarActor. The identity of the Car would also expose the capacity of the BillingActor to determine who the car owner was, thus determining who to bill.

### Designing a Nested Invigoration Chain

Nested Invigoration Chains can be designed quite easily, merely by bullet-pointing the workflow, creating a trammel for each bullet point, and for each trammel, designing the TObject and TActor, taking into account that each one's starting state will be determined by the output state of the nested trammel.

For example, let's design a simple CreateUser trammel chain.

In this example, we will create a user and create the user's micro-site within the application-wide multi-user infrastructure, and then finally, we will email them a link saying that their account can be logged into.

We will also use TO / TA class naming notation to name TObject and TActor classes, respectively. This will not just be reflected in the Invigoration Nesting, but also in the class filenames, wherever the software engineer places them. This convention, similar to naming interfaces with a preceding 'I' (e.g. IDisposable), will make the Invigoration Matrix obvious to anyone who looks at the application's directory structures.

The trammel-chain, which will define the Invigorator nesting, is composed from the following bullet-points:

- Determine if User's desired UserName is available - TOUserAccountApplication, TACreateUserName, returns TAUserAccountCreationDetailsValidation
- Determine if User's information is valid and complete - TOUserAccountCreationDetailsSubmission, TAUserAccountCreationDetailsValidation, returns TACUserMicrositeCreation
- Create UserMicrosite - TOCreateUserMicrosite, TACUserMicrositeCreation, returns TAEmailUserAccountReady
- Email User - TOEmailUserAccountReady, TAEmailUserAccountReady returns TAEmailUserAccountReady

Now we can scratch out the prevailing psuedocode:

```
using(CarActor carActor = new CarActor())
{
  carActor.Path = "cars/W123ABC"; // pseudocode that illustrates the capacity to acquire a Car object
  
  TAEmailUserSiteReady cascadedResult = /* Read the order from bottom to top - such is the nature of nesting! */
                        await Invigorator.ActAsync<TOEmailUserSiteReady,TAEmailUserSiteReady>(
                        await Invigorator.ActAsync<TOCreateUserMicrosite,TACreateUserMicrosite>(
                        await Invigorator.ActAsync<TOUserAccountCreationDetailsSubmission,TAUserAccountCreationDetailsSubmission>(
                        await Invigorator.ActAsync<TOCreateUserApplication,TACreateUserName>(carActor))));
  if(!cascadedResult.IsSuccess)
  {
    // Return cascadedResult.Message to the user so that they know what to fix before pressing submit again
  }
  else
  {
    // Inform the user that an email will be sent to them when 
    // the account is created, requiring them to verify their 
    // email address before they can log in.
  }
}
```

_Now it is just a case of creating each TObject and TActor !!!_




