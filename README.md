## Yatter.Invigoration

# Invigoration Pattern a.k.a The Invigorator's Trammel

_If Tetris was applied to Software Engineering, it would be about the Invigoration Model._

A series of pre-existing shapes are subjected to being dynamically arranged by a pack-and-place management tool which allows individual shapes to be placed subject to the arrangement of those shapes that have preceded them; paralellism is achieved by the same game being played in parallel, with fanning in being represented by the accumulated scores of each of the games complementing the benefits of the existential arrangement patterns of each.

Invigoration is particularly suited to being utilised within a host of existing design patterns and in being so are minutiae that can be shaped in any arrangement to represent any of these patterns.

If the art of design was a sand-castle competition, then all the shapes are best represented when the grains of sand are the invigorators that are the basic building block of the Invigoration Pattern.

_In such a case, the competition is the ubiquitous app-store._

## Benefits

For example, *Invigorators* can be arranged to:

- be encapsulted to achieve Composite pattern
- be collectively deployed to achieve Facade pattern
- be lineally ordered to achive Adapter pattern
- be dynamically selected to achieve Factory pattern

Examples where *Invigorators* are particularly useful are:

- when they are orchestrated within Azure's Dynamic Functions to take single steps inputs, supplying single step outputs, in a single line
- prevail as single line in an HttpTrigger Function or MVC Controller to economically encapsulate functionality that can be used elsewhere
- be multiply encapsulated to achieve Facade pattern so that they can be deployed to any of a multiple of facades
- software engineer's seeing the word _Invigorator.Act..._ in a line of code will immediately know it's inner structure and will thus more readily adapt to being introduced to an existing code-base

## Definitions

### INVIGORATION

- 'Invigoration' is the "the activity of giving vitality and vigour to something", which in the Software Engineering sense, is achieved by an Actor causing an Action to be undertaken upon an Object.
  
### INVIGORATION PATTERN / INVIGORATOR'S TRAMMEL

- An 'Invigoration Pattern' also known as an 'Invigorator's Trammel', is a statement that defines the relationship of an Object with it's Actor, within the constraints of the Trammel.
  
### INVIGORATOR

- An 'Invigorator' is "an agent that gives or restores life or vigor", which in the Software Engineering sense, is the mechanism that exposes the channel of the invigoration trammel (it's freedoms), as well as it's constraints.
  
### TRAMMEL

- A 'Trammel' (noun) is defined as "restrictions or impediments to freedom of action.", with 'freedom within the channel of the trammel' implied to exist by the very nature of the constraints.
- A pictorial grasp of how a trammel can dynamically convert singular lines of actions into a range of dynamic opportunities, can be obtained by looking at videos on YouTube about [The Trammel of Archimedes](https://www.youtube.com/results?search_query=archimedes+Trammel). 

16 Invigorator Trammels are possible, each illustrated below, of which the first 15 can be derived by removing all of the exposed permutations, or by the synchronous reduction, of the 16th:

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


