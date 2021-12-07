# HxSystem
Documentation on how to use HxSystem

## Dependencies
TODO

## Events
```csharp
public event EventHandler<DragEventArgs> OnDragEnter;
public event EventHandler<DragEventArgs> OnDragDrop;
```

## Public
```csharp
public Random Random;

public Viewport Viewport;
public GraphicsDeviceManager GraphicsDeviceManager
public GraphicsDevice GraphicsDevice;
public ContentManager ContentManager;

public Game Game;
public Type GameType => Game.GetType();

public GameWindow GameWindow;


public Point ViewportCenter;
public float ViewportAspectRatio;

public int ViewportWidth;
public int ViewportHeight;

public int PreferredBackBufferHeight;
public int PreferredBackBufferWidth;

public bool AllowDrop; //default false
```

## How to use
- [Init](#init)
- [Update](#update)

### Init
there three ways on how to use HxSystem.

First way is to use HxSystem only for the other HxNuGet packages, HxSystem has as dependencies.
If you dont want to use HxSystem specific methodes but you still want to use HxInput, HxTime, etc. all you have to do is to call the Update function of HxSystem
```csharp
Hx.Instance.Update(gameTime);
```

If you want to use HxSystem spoecific methodes and functinalities you have to call the Init function in you main initilization method.
Init has three different overloads.

public void Init(); //SetGame has to be called first
public void Init(Game game);
public void Init(Game game, GraphicsDeviceManager graphicsDeviceManager);

