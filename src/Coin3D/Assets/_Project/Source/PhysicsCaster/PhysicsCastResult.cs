using UnityEngine;

namespace Coin.Source
{
    public struct PhysicsCastResult
    {
        public bool WasHit;
        public RaycastHit HitInfo;

        public PhysicsCastResult(bool wasHit, RaycastHit hitInfo)
        {
            WasHit = wasHit;
            HitInfo = hitInfo;
        }
    }
}