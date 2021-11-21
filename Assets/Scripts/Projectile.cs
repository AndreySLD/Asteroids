using UnityEngine;

namespace Asteroids
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private int _damage;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out CharacterStats target))
            {
                target.HP -= _damage;
            }
        }
    }
}