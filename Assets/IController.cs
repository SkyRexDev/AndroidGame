using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ITouchController 
{
    public void Tap(Vector2 position_on_screen);
    public void Drag(Vector2 position);
    public void Pinch(Vector2 firstTouch, Vector2 secondTouch);
    public void PinchEnded();
}
