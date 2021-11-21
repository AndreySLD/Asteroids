using System;
using UnityEngine;

namespace Asteroids.Prototype

{
    internal sealed class EnemyPrototype : MonoBehaviour
    {
        private void Start()
        {
            EnemyData enemyData = new EnemyData
            {
                Hp = new Health(100, 100),
                Speed = 100
            };
            EnemyData newEnemyData = enemyData.DeepCopy();
        }
    }
}
