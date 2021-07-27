using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalRotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 1;

    private bool _isRotatesRight = true;

    void Update()
    {
        if (transform.rotation.eulerAngles.y > 80 || transform.rotation.eulerAngles.y < 0)
        {
            ChangeRotationDirection();
        }
        if (_isRotatesRight)
        {
            transform.Rotate(-Vector3.right, 1 * _rotationSpeed);
        }
        else
        {
            transform.Rotate(-Vector3.left, 1 * _rotationSpeed);
        }
    }

    private void ChangeRotationDirection()
    {
        _isRotatesRight = !_isRotatesRight;
    }
}
