using UnityEngine;

namespace Asteroids
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private void Start()
        {
            new GameObject().AddBoxCollider2D().AddBoxCollider2D().AddRigidbody2D(5.0f);
        }
    }
}

