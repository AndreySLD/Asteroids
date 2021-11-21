using Asteroids.Prototype;
using UnityEngine;

namespace Asteroids
{
    internal class EnemyShipFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
        public Enemy Resurrect(EnemyData enemyData)
        {
            var resurrectedEnemy = Object.Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));

            resurrectedEnemy.DependencyInjectHealth(enemyData.Hp);

            return resurrectedEnemy;
        }
    }
}