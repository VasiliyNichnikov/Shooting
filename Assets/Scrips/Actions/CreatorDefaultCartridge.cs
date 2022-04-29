using Scrips.Cartridge;
using UnityEngine;

namespace Scrips.Actions
{
    public class CreatorDefaultCartridge: ICreatorCartridge
    {
        private readonly GameObject _prefab;
        private readonly Transform _parent;
        
        public CreatorDefaultCartridge(GameObject prefab, Transform parent)
        {
            _prefab = prefab;
            _parent = parent;
        }
        
        public ICartridge Create(Vector3 position)
        {
            GameObject cartridge = Object.Instantiate(_prefab, position, Quaternion.identity);
            cartridge.transform.SetParent(_parent);
            return cartridge.GetComponent<ICartridge>();
        }
    }
}