# HxSystem
Documentation on how to use HxSystem

## Dependencies
TODO

## Events
```csharp
public event EventHandler<DragEventArgs> OnDragEnter; // Needs Game
public event EventHandler<DragEventArgs> OnDragDrop; // Needs Game
```

## Public
```csharp
public Random Random;

public Viewport Viewport; // Needs GraphicsDevice
public GraphicsDeviceManager GraphicsDeviceManager; //Needs GraphicsDeviceManager, lol
public GraphicsDevice GraphicsDevice; // Needs GraphicsDevice
public ContentManager ContentManager; // Needs Game

public Game Game; // Needs Game
public Type GameType => Game.GetType(); // Needs Game

public GameWindow GameWindow; // Needs Game

public Point ViewportCenter; // Needs GraphicsDevice
public float ViewportAspectRatio; // Needs GraphicsDevice

public int ViewportWidth; // Needs GraphicsDevice
public int ViewportHeight; // Needs GraphicsDevice

public int PreferredBackBufferHeight; //Needs GraphicsDeviceManager
public int PreferredBackBufferWidth; //Needs GraphicsDeviceManager

public bool AllowDrop; //default false
```

## How to use
- [Init](#init)
- [Update](#update)
- [Example Game](#example)
- [Methods](#methods)
- [How To Use Drag And Drop](#drag-and-drap)

### Init
there are "three" ways on how to use HxSystem.

First way is to use HxSystem only for the other HxNuGet packages, HxSystem has as dependencies.
If you dont want to use HxSystem specific methods but you still want to use HxInput, HxTime, etc. all you have to do is to call the Update function of HxSystem
```csharp
Hx.Instance.Update(gameTime);
```

If you want to use HxSystem spoecific methods and functinalities you have to call the Init function in your main init method.
Init has three different overloads.

```csharp
public void Init(); //SetGame has to be called first
public void Init(Game game); // some methods will throw null pointer because GraphicsDeviceManager is not set, not needed tho. Just check which methods you can use
public void Init(Game game, GraphicsDeviceManager graphicsDeviceManager); //Recommended
```

### Update
```csharp
Hx.Instance.Update(gameTime);
```

### Example

NOTE
TextureContentLoader is a self coded class and comes not with HxSystem.
TextureContentLoader uses features from HxManager
[TextureContentLoader.cs](https://github.com/SameplayerDE/HxNuGet/blob/master/TextureContentLoader.cs)
```csharp

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphicsDeviceManager;
        private SpriteBatch _spriteBatch;
        
        public Game1()
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            _graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            Window.AllowUserResizing = true;

            _graphicsDeviceManager.PreferredBackBufferHeight = 720;
            _graphicsDeviceManager.PreferredBackBufferWidth = 1280;
            
            _graphicsDeviceManager.ApplyChanges();
        }

        protected override void Initialize()
        {
            Hx.Instance.Init(this, _graphicsDeviceManager);
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // ReSharper disable once HeapView.ObjectAllocation.Evident
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureContentLoader.Instance.LoadContent(Content);
        }

        protected override void Update(GameTime gameTime)
        {
            Hx.Instance.Update(gameTime);
            if (!IsActive)
            {
                return;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            base.Draw(gameTime);
        }
    }
}
```

### Methods
```csharp
public void Init();
public void Init(Game game);
public void Init(Game game, GraphicsDeviceManager graphicsDeviceManager);
public void SetGraphicsDeviceManager(GraphicsDeviceManager graphicsDeviceManager);

internal void SetGraphicsDevice(GraphicsDevice graphicsDevice) // called by SetGraphicsDeviceManager
{
    _graphicsDevice = graphicsDevice;
    Graphics.Instance.SetGraphicsDevice(_graphicsDevice);
}

public void SetGame<T>(T game) where T : Game;
public void Update(GameTime gameTime);
public float GetRandomFloat();
public float GetRandomFloat(float min, float max, float step = 1f);
public int GetRandomInt32();
public int GetRandomInt32(int min, int max, int step = 1);
```

### Drag and Drop
```csharp
void DragDrop(object sender, DragEventArgs e)
{
    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
    foreach (string file in files) Console.WriteLine(file);
}

void DragEnter(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
}

protected override void Initialize()
{
    Hx.Instance.Init(this, _graphicsDeviceManager);

    Hx.Instance.AllowDrop = true;
    Hx.Instance.OnDragDrop += DragDrop;
    Hx.Instance.OnDragEnter += DragEnter;

    base.Initialize();
}
```
