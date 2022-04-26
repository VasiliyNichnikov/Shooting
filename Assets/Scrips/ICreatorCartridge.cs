using Scrips.Cartridge;
using UnityEngine;

namespace Scrips
{
    public interface ICreatorCartridge
    {
        public ICartridge Create(Vector3 position);
    }
}