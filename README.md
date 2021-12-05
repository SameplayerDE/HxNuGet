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
- [Update](#update_input)
- [Mouse Input](#mouse_input)
- [Keyboard Input](#keyboard_input)
- [GamePad Input](#gamepad_input)


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
Here are all the methodes related to mouse input

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
