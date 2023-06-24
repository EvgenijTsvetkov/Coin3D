using UnityEngine;

namespace Coin.Source
{
    public interface IPhysicsCaster
    {
        PhysicsCastResult Raycast(LayerMask layerMask);
    }
}