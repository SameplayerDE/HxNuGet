# HxNuGet
Documentation on how to use each HxNuGet package

- [HxInput](#input)
- [HxTime](#time)
- [HxManager](#manager)
- [HxSystem](#system)

# input
# HxInput
## Dependencies
TODO

## How to use
- [Update](#input_update)
- [Mouse Input](#input_mouse)
- [Keyboard Input](#input_keyboard)
- [GamePad Input](#input_gamepad)

# input_update
### Update
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
