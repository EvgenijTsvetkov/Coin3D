using System;
using UnityEngine;

namespace Coin.Source
{
    public interface IInputService
    {
        Vector2 TouchPosition { get; }
        event Action OnTouch;
    }
}