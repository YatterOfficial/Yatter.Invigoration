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

*Invigorators* are particularly useful when:

- they are orchestrated within Azure's Dynamic Functions to take single steps inputs, supplying those single step outputs, each in a single line of code
- they are numerously encapsulated using Composite Pattern into single Facades that can be deployed in any of a variety of contexts and environments
- they prevail as single line-of-code in anything from an app that glows in front of a user's face, to single line-of-code in an HttpTrigger Function, MVC Controller, or Worker in the cloud, where that line-of-code is merely a pixel in the data-scientist's mind's eye of the whole composite world-wide data-traffic-route fly-ways that can wholly be seen in the data-scientist's imagination of the night-sky
- it is desired to efficiently arrange functionality into ordered matrices of TObjects and TActor
- software engineer's, seeing the word _Invigorator.Act..._ in a line of code, will immediately know it's inner structure - who will thus more readily adapt to being introduced to an existing code-base - who will then also know approximately where to easily find the invigorated matrices of TObjects and TActors, in the code-base, no matter how convoluted the actual applications workflows are
- TObject and TActor matrices are essentially a look-up spreadsheet of the capability of an application


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
- A pictorial grasp of how a trammel can dynamically convert singular TObjects and TActors into a range of dynamic opportunities, can be obtained by looking at videos on YouTube about [The Trammel of Archimedes](https://www.youtube.com/results?search_query=archimedes+Trammel). The most basic representation is the one at this [this](https://youtu.be/7Fn-26Jmi5E?t=46) - thanks Mathologer - where each of the two axis can be seen to represent a generics TObject and TActor, respectively.
- When a Software Engineer sees an Invogorator, because he knows that an Invigorator's signature is based upon TObjects and TActors, then his knowing that the Trammel-T is the base-class of each, he immediately knows where to find the Object that is acted upon, or the Action that the Actor effects upon the Object 

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

e.g. See below:

```
CarActor acted = await Yatter.Invigoration.Invigorator.ActAsync<Car,CarActor>(carActor);
```


