using UnityEngine.AI;
using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private float _ballSpeed = 100;

    private GameObject _objectToFollow;

    private Rigidbody _rigidbody;

    private Vector3 _direction;
    private Vector3 _playerRotation;

    private void OnEnable()
    {
        PlayerMovement.OnChangeDirection += ChangeDirection;
    }

    private void OnDisable()
    {
        PlayerMovement.OnChangeDirection -= ChangeDirection;
    }

    private void ChangeDirection(Vector3 direction, Vector3 playerRotation)
    {
        _direction = direction;
        _playerRotation = playerRotation;
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _ballSpeed = _ballSpeed + Random.Range(-30, 30);
    }

    private void FixedUpdate()
    { 
        if (_objectToFollow != null)
        {
            transform.localRotation = Quaternion.Euler(_direction.z, _playerRotation.y - 90, 0);
            _rigidbody.velocity = (_objectToFollow.transform.position - gameObject.transform.position).normalized * Time.deltaTime * _ballSpeed * 3;
        }
    }

    public void SetObjectToFollow(GameObject player)
    {
        _objectToFollow = player;
    }
    
    public GameObject GetObjectToFollow()
    {
        return _objectToFollow;
    }

}
