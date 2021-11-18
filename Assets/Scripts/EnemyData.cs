using System;

namespace Asteroids.Prototype
{
    [Serializable]
    internal sealed class EnemyData
    {
        public float Speed;
        public Health Hp;

        public override string ToString()
        {
            return $"Speed {Speed} Hp {Hp}";
        }
    }
}
