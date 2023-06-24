using System;
using UnityEngine;

namespace Coin.Source
{
    public class InputService : MonoBehaviour, IInputService
    {
        public event Action OnTouch;
        
        public Vector2 TouchPosition => Input.GetTouch(0).position;

        private void Update()
        {
            if (HasTouch()) 
                CheckTouchEnded();
        }
        
        private bool HasTouch()
        {
            return Input.touchCount > 0;
        }

        private void CheckTouchEnded()
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase != TouchPhase.Canceled && touch.phase != TouchPhase.Ended) 
                return;
            
            OnTouch?.Invoke();
        }
    }
}