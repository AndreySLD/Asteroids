using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Weapon
    {
        private Transform _startPosition;
        private GameObject _projectilePrefab;
        private float _projectileSpeed;

        public Weapon(Transform startPosition, GameObject bulletPrefab, float speedBullet)
        {
            _startPosition = startPosition;
            _projectileSpeed = speedBullet;
            _projectilePrefab = bulletPrefab;
        }
        public void Shoot()
        {
            var bulletGameObject = Object.Instantiate(_projectilePrefab, _startPosition.position, _startPosition.rotation);
            var rigidbody = bulletGameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(_startPosition.forward * _projectileSpeed, ForceMode.Impulse);
        }
    }
}
