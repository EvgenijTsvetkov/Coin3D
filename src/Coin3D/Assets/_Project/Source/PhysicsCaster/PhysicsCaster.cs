using UnityEngine;
using Zenject;

namespace Coin.Source
{
    public class PhysicsCaster : IPhysicsCaster
    {
        private IInputService _inputService;
        private IMainCameraProvider _mainCameraProvider;

        [Inject]
        public void Construct(IMainCameraProvider mainCameraProvider, IInputService inputService)
        {
            _inputService = inputService;
            _mainCameraProvider = mainCameraProvider;
        }

        public PhysicsCastResult Raycast(LayerMask layerMask)
        {
            Vector2 touchPosition = _inputService.TouchPosition;
            Ray ray = _mainCameraProvider.Value.ScreenPointToRay(touchPosition);
            bool wasHit = Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit, float.MaxValue, layerMask);

            return new PhysicsCastResult(wasHit, hit);
        }
    }
}
