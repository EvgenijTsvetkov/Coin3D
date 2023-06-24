using UnityEngine;

namespace Coin.Source
{
    [RequireComponent(typeof(ColorSwapper))]
    [RequireComponent(typeof(Rotator))]
    public class Interactable : MonoBehaviour
    {
        private ColorSwapper _colorSwapper;
        private Rotator _rotator;

        private void Awake()
        {
            _colorSwapper = GetComponent<ColorSwapper>();
            _rotator = GetComponent<Rotator>();
        }

        public void Interact()
        {
            _colorSwapper.SwapToRandomColor();
            _rotator.SwapDirectionRotation();
        }
    }
}