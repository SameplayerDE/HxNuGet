# HxNuGet
Documentation on how to use each HxNuGet package

- [HxInput](#hxinput)
  - Dependencies
  - Events
  - Public
  - How To Use
- [HxTime](#hxtime)
- [HxManager](#hxmanager)
- [HxSystem](#hxsystem)


# HxInput
## Dependencies
TODO

## Events
```csharp
public event EventHandler<KeyboardKeyEventArgs> OnKeyDown;
public event EventHandler<KeyboardKeyEventArgs> OnKeyUp;

public event EventHandler<KeyboardCharEventArgs> OnCharDown;

public event EventHandler<MouseMoveEventArgs> OnMouseMove;

public event EventHandler<GamePadEventArgs> OnGamePadConnect;
public event EventHandler<GamePadEventArgs> OnGamePadDisconnect;
```

## Public
```csharp
public Vector2 LatestMouseDelta;

public Point LatestMousePosition;
public Point PreviousMousePosition;

public MouseState LatestMouseState;
public MouseState PreviousMouseState;

public TouchPanelState LatestTouchPanelState;
public TouchPanelState PreviousTouchPanelState;

public TouchCollection LatestTouchCollection;
public TouchCollection PreviousTouchCollection;

public KeyboardState LatestKeyboardState;
public KeyboardState PreviousKeyboardState;

public GamePadState[] LatestGamePadStates;
public GamePadState[] PreviousGamePadStates;
```

## How to use
- [Update](#update-input)
- [Mouse Input](#mouse-input)
- [Keyboard Input](#keyboard-input)
- [GamePad Input](#gamepad-input)


### Update Input 
If you use HxInput without HxSystem then you have to call this code to update the input device states
```csharp
Input.Instance.Update(gameTime);
```

If you use HxInput with HxSystem then you have to call this code to update the input device states
```csharp
Hx.Instance.Update(gameTime);
```

### Mouse Input

```csharp
public Vector2 MouseDistanceVectorFrom(Vector2 position);
public Vector2 MouseDistanceVectorFrom(Point position);
public Point MouseDistancePointFrom(Vector2 position);
public Point MouseDistancePointFrom(Point position);
public bool IsMouseKeyDownOnce(MouseButton button);
public bool IsMouseKeyDown(MouseButton button);
public bool IsMouseKeyUpOnce(MouseButton button);
public bool IsMouseKeyUp(MouseButton button);
```

### Keyboard Input

```csharp
public bool IsKeyboardKeyDownOnce(Keys key);
public bool IsKeyboardKeyDown(Keys key);
public bool WasKeyboardKeyDown(Keys key);
public bool IsKeyboardKeyUpOnce(Keys key);
public bool IsKeyboardKeyUp(Keys key);
public bool WasKeyboardKeyUp(Keys key);
```

#### Example
This code prints "Key Pressed" only one time when the key "G" was pressed

Using OnKeyDown Event
```csharp
public void foo(object sender, KeyboardKeyEventArgs args)
{
    if (args.Key == Keys.G)
    {
        Console.WriteLine("Key Pressed");
    }
}

//Somewhere in the code
Input.Instance.OnKeyDown += foo;
```

Using IsKeyboardeKeyDownOnce Method
```csharp
if (Input.Instance.IsKeyboardeKeyDownOnce(Keys.G))
{
  Console.WriteLine("Key Pressed");
}
```

### GamePad Input

```csharp
public bool IsGamepadButtonDown(PlayerIndex index, Buttons button);
public bool IsGamepadButtonUp(PlayerIndex index, Buttons button);
public bool WasGamepadButtonDown(PlayerIndex index, Buttons button);
public bool WasButtonUp(PlayerIndex index, Buttons button);
public bool IsGamepadButtonPressed(PlayerIndex index, Buttons button);
public bool IsButtonReleased(PlayerIndex index, Buttons button);
public bool IsGamePadConnected(PlayerIndex index);
public bool WasGamePadConnected(PlayerIndex index);
public bool IsGamePadDisconnected(PlayerIndex index);
public bool WasGamePadDisconnected(PlayerIndex index);
```

### Touch Input
