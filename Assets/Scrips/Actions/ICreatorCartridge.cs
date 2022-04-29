using Scrips.Cartridge;
using UnityEngine;

namespace Scrips.Actions
{
    public interface ICreatorCartridge
    {
        public ICartridge Create(Vector3 position);
    }
}