using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            Enemy.CreatePirateEnemy(new Health(200.0f, 200.0f));

            IEnemyFactory asteroidFactory = new AsteroidFactory();
            asteroidFactory.Create(new Health(100.0f, 100.0f));

            Enemy.Factory = asteroidFactory;

            Enemy.Factory.Create(new Health(100.0f, 100.0f));


            IEnemyFactory pirateFactory = new EnemyShipFactory();
            pirateFactory.Create(new Health(200.0f, 200.0f));            
            
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);

            
        }
    }
}