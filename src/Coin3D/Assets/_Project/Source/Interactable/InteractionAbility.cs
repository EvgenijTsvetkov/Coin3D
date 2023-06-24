using UnityEngine;
using Zenject;

namespace Coin.Source
{
    public class InteractionAbility : MonoBehaviour
    {
        [SerializeField] private LayerMask _interactableLayer;

        private IPhysicsCaster _physicsCaster;

        [Inject]
        public void Construct(IPhysicsCaster physicsCaster)
        {
            _physicsCaster = physicsCaster;
        }

        public void TryInteract()
        {
            if (TryGetAvailableObjectToInteract(out Interactable interactable) == false)
                return;

            interactable.Interact();
        }

        public bool TryGetAvailableObjectToInteract(out Interactable interactable)
        {
            interactable = null;

            PhysicsCastResult result = _physicsCaster.Raycast(_interactableLayer);
            if (result.WasHit == false)
                return false;

            if (result.HitInfo.collider.TryGetComponent(out interactable) == false)
                return false;

            return interactable;
        }
    }
}