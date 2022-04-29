using Scrips.Cartridge;
using UnityEngine;

namespace Scrips.Wall
{
    public static class Utilities
    {
        public static ICartridge GetCartridge(GameObject obj)
        {
            return obj.GetComponent<ICartridge>();
        }
    }
}