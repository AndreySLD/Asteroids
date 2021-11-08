using UnityEngine;


namespace Asteroids
{
    public class EnemyShip : Enemy
    {
        [SerializeField] private float _movementSpeed;
        private float _horizontalMoveAmount;
        private float _verticalMoveAmount;
        private float _delta;
        private MoveTransform _moveTransform;


        private void Awake()
        {
            _moveTransform = new MoveTransform(transform, _movementSpeed);            
        }
        private void Start()
        {
            _delta = Time.deltaTime;
        }

        private void Update()
        {           
            Move(_delta);
        }

        private void Move(float delta)
        {
            _horizontalMoveAmount = Random.Range(0.0f, 1.0f);
            _verticalMoveAmount = Random.Range(0.0f, 1.0f);
            _moveTransform.Move(_verticalMoveAmount, _verticalMoveAmount, delta);
        }
    }
}
