using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids.Object_Pool
{
    internal sealed class ProjectilePool
    {
        private readonly Dictionary<string, HashSet<Projectile>> _enemyPool;
        private readonly int _capacityPool;
        private Transform _rootPool;
        
        
        public ProjectilePool(int capacityPool)
        {
            _enemyPool = new Dictionary<string, HashSet<Projectile>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new GameObject(NameManager.POOL_BULLET).transform;
            }
        }
        
        public Projectile GetEnemy(string type)
        {
            Projectile result;
            switch (type)
            {
                case "Asteroid":
                    result = GetAsteroid(GetListEnemies(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Не предусмотрен в программе");
            }

            return result;
        }

        private HashSet<Projectile> GetListEnemies(string type)
        {
            return _enemyPool.ContainsKey(type) ? _enemyPool[type] : _enemyPool[type] = new HashSet<Projectile>();
        }

        private Projectile GetAsteroid(HashSet<Projectile> enemies)
        {
            var bullets = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (bullets == null )
            {
                var laser = Resources.Load<Projectile>("Bullet");
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    enemies.Add(instantiate);
                }

                GetAsteroid(enemies);
            }
            bullets = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return bullets;
        }

        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool);
        }

        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }
    }
}