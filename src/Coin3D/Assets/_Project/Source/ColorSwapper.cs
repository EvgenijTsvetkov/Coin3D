using UnityEngine;

namespace Coin.Source
{
    [RequireComponent(typeof(Renderer))]
    public class ColorSwapper : MonoBehaviour
    {
        private Renderer _selfRenderer;

        private void Awake()
        {
            _selfRenderer = GetComponent<Renderer>();
        }

        public void SwapToRandomColor()
        {
            _selfRenderer.material.color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
            );
        }
    }
}