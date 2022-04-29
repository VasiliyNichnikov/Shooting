using UnityEngine;

namespace Scrips.Wall
{
    public class CollisionWithCartridge : MonoBehaviour
    {
        private void OnCollisionExit(Collision other)
        {
            var cartridge = Utilities.GetCartridge(other.gameObject);
            cartridge?.DestroyYourself();
        }
    }
}
