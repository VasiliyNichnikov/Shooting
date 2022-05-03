using UnityEngine;

namespace Scrips.Wall
{
    public class CollisionWithCartridge : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            var cartridge = Utilities.GetCartridge(other.gameObject);
            cartridge?.DestroyYourself();
        }
    }
}
