using UnityEngine;

namespace Scrips.Wall
{
    public class CollisionWithCartridge : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            if (Utilities.CheckCartridge(other.gameObject))
            {
                Destroy(other.collider.gameObject);
            }
        }
    }
}
