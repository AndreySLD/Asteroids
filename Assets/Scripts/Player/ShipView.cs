using UnityEngine;

namespace Asteroids
{
    public class ShipView : MonoBehaviour
    {
        private Camera _camera;
        void Awake()
        {
            _camera = Camera.main;            
        }
        public Camera Camera
        {
            get => _camera;
        }        
    }
}
