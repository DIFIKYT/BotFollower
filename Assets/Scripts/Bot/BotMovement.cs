using UnityEngine;

public class BotMovement : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _speed;

    private readonly float DistanceFromTargetPosition = 5;
    private Rigidbody _rigibody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigibody = GetComponent<Rigidbody>();
    }

    public void MoveTo()
    {
        _direction = _player.transform.position - transform.position;
        _direction.Normalize();

        if ((_player.transform.position - transform.position).sqrMagnitude > DistanceFromTargetPosition)
            _rigibody.MovePosition(transform.position + (_speed * Time.deltaTime * _direction));
    }
}