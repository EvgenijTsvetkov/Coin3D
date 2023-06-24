using UnityEngine;

namespace Coin.Source
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotation = new Vector3(0f, 25f, 50f);
     
        
        private Transform _selfTransform;

        private void Awake()
        {
            _selfTransform = transform;
        }

        private void Update()
        {
            Vector3 rotation = _rotation * Time.deltaTime;
            _selfTransform.Rotate(rotation.x, rotation.y, rotation.z, Space.Self);
        }

        public void SwapDirectionRotation()
        {
            _rotation *= -1;
        }
    }
}
