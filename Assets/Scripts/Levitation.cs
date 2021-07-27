using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitation : MonoBehaviour
{
    [SerializeField]
    private float _levitationSpeed;
    [SerializeField]
    private float _levitationHeight;

    private bool _isMovingUp = true;

    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        if (transform.position.y > _startPos.y + _levitationHeight || transform.position.y < _startPos.y - _levitationHeight)
        {
            ChangeDirection();
        }
        if (_isMovingUp)
        {
            transform.Translate(Vector3.up * _levitationSpeed / 10, Space.World);
        }
        else
        {
            transform.Translate(Vector3.down * _levitationSpeed / 10, Space.World);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    private void ChangeDirection()
    {
        _isMovingUp = !_isMovingUp;
    }
}
