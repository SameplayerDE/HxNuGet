# HxInput
Documentation on how to use each HxIput package

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
public void TextEntered(object sender, TextInputEventArgs e);
```

#### Example
How to process text input with keyboard


Game1 Class
```csharp
public class Game1
{
    public Game1() {
        /*
         * Your Code
        **/
        Window.TextInput += InputManager.Instance.TextEntered; //Registers Methode To TextInput Event
    }
}
```

TextInput Class - used in HxUserInterface (not released yet)
```csharp

public string Text = "Text"; //Content Of The TextInput
public SpriteFont Font;

public bool Focus = false; //If The TextInput Has Focus
public bool Edit = false; //If The TextInput Can Be Edited

public TextInput()
{
    Input.Instance.OnCharDown += OnInput;
}

public void Update(GameTime gameTime);
public void Draw(SpriteBatch spriteBatch, GameTime gameTime);

private void OnInput(object sender, KeyboardCharEventArgs e)
{
    if (!Focus)
    {
        return;
    }
    switch (e.Char)
    {
        case '\a':
            break;
        case '\f':
            break;
        case '\r':
            break;
        case '\n':
            break;
        case '\t':
            break;
        case '\v':
            break;
        case '\0':
            break;
        case '\x1B':
            break;
        case ' ':
            Text = Text?.Insert(Text.Length, " ");
            break;
        case '\b':
        {
            if (Text.Length - 1 >= 0)
            {
                Text = Text?.Remove(Text.Length - 1);
            }
            break;
        }
        default:
            if (Font.Characters.Contains(e.Char))
            {
                Text = Text?.Insert(Text.Length, e.Char.ToString());
            }
            break;
    }
}
````


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

```csharp
public bool IsTouchAvailable();
public TouchLocation GetNearestTouchLocation(Vector2 location);
```
