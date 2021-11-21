using Asteroids.Prototype;

namespace Asteroids
{
    internal interface IEnemyFactory
    {
        Enemy Create(Health hp);

        Enemy Resurrect(EnemyData enemyData);
    }
}