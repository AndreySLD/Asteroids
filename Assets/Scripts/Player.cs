using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : CharacterStats
    {        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (HP <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                HP--;
            }
        }
    }
}