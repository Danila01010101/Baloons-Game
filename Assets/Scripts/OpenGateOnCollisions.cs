using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateOnCollisions : MonoBehaviour
{
    [SerializeField]
    private Vector3 _endRotationDirection;
    [SerializeField]
    private Vector3 _rotationDirection;

    private int _collisionsAmount = 0;
    private bool _isClosed = true;

    private void Update()
    {
        if (_collisionsAmount >= 2 && _isClosed)
        {
            transform.Rotate(_rotationDirection);
            _isClosed = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        _collisionsAmount += 1;
    }
}
