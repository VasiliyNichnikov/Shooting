using System.Collections;
using UnityEngine;

namespace Scrips.Cartridge
{
    public class FlightCartridge : MonoBehaviour, ICartridge
    {
        private Transform _thisTransform;
        
        public void ToRun(IMovement movement)
        {
            StartCoroutine(Run(movement));
        }

        private IEnumerator Run(IMovement movement)
        {
            while (true)
            {
                _thisTransform.Translate(movement.GetNextPoint());
                yield return null;
            }
        }

        private void Awake()
        {
            _thisTransform = transform;
        }
    }
}