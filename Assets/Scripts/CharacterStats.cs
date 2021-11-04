using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal class CharacterStats : MonoBehaviour
    {
        [SerializeField] private float _hp;
        public float HP
        {
            get => _hp;
            set => _hp = value;
        }
    }    
}
