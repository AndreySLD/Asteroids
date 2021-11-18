using Asteroids.Prototype;
using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/asteroid"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
        public Enemy Resurrect(EnemyData enemyData)
        {
            return default;
        }
    }
}
