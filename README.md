# HxNuGet
Documentation on how to use each HxNuGet package

- [HxInput](#hxinput)
- [HxTime](#hxtime)
- [HxManager](#hxmanager)
- [HxSystem](#hxsystem)


# HxInput
## Dependencies
TODO

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
# input_mouse
### Mouse Input
- [MouseDistanceVectorFrom]
- [MouseDistancePointFrom]
- [IsMouseKeyDownOnce]
- [IsMouseKeyDown]
- [IsMouseKeyUpOnce]
- [IsMouseKeyUp]

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
