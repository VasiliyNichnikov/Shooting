using UnityEngine;

namespace Scrips.Weapon
{
    public class CalculatorDirection
    {
        private readonly Transform _weapon;
        private readonly Transform _spawnCartridge;
        
        public CalculatorDirection(Transform weapon, Transform spawnCartridge)
        {
            _weapon = weapon;
            _spawnCartridge = spawnCartridge;
        }

        public Vector3 GetDirection()
        {
            Vector3 b = _spawnCartridge.position;
            Vector3 a = _weapon.TransformPoint(new Vector3(0, _spawnCartridge.localPosition.y, 0));
            return b - a;
        }
    }
}