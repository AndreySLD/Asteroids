using UnityEngine;

namespace Asteroids.Prototype
{
    internal sealed class ExamplePrototype : MonoBehaviour
    {
        private void Start()
        {
            PlayerData playerData = new PlayerData
            {
                Hp = new Health(100, 100),
                Speed = 100
            };

            PlayerData playerDataNew = playerData.DeepCopy();
            playerDataNew.Hp.Current = 200;

            Debug.Log(playerData);
            Debug.Log(playerDataNew);
        }
    }
}