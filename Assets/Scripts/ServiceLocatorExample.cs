using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class ServiceLocatorExample : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.SetService<IPool>(new EnemyPool(1));
        }

        public void RemoveThisPoolAlready()
        {
            ServiceLocator.Resolve<IPool>().RemovePool();
        }
    }
}
