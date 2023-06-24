using UnityEngine;
using Zenject;

namespace Coin.Source
{
    [RequireComponent(typeof(InteractionAbility))]
    public class PirateCoin : MonoBehaviour
    {
        private IInputService _inputService;
        private InteractionAbility _interactionAbility;

        [Inject]
        public void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void Awake()
        {
            _interactionAbility = GetComponent<InteractionAbility>();
            
            _inputService.OnTouch += OnTouchHandler;
        }

        private void OnDestroy()
        {
            _inputService.OnTouch -= OnTouchHandler;
        }

        private void OnTouchHandler()
        {
            _interactionAbility.TryInteract();
        }
    }
}