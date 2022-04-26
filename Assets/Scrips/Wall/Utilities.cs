using Scrips.Cartridge;
using UnityEngine;

namespace Scrips.Wall
{
    public static class Utilities
    {
        public static bool CheckCartridge(GameObject obj)
        {
            return obj.GetComponent<ICartridge>() != null;
        }
    }
}