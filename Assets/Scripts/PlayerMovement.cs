using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public delegate void DirectionChanged(Vector3 direction, Vector3 playerRotation);

    public static event DirectionChanged OnChangeDirection;

    [SerializeField]
    private float _turnSpeed = 1f;

    private Vector3 _direction;

    void Update()
    {
        if (Input.touchCount > 0 )
        {
            Move();
        }
    }

    private void Move()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchpos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - touch.deltaPosition.x * _turnSpeed);

        _direction = touchpos - gameObject.transform.localPosition;
        OnChangeDirection(_direction, transform.parent.gameObject.transform.eulerAngles);
        var direction = _direction.normalized;
        var _directionToMove = new Vector3(0, -direction.z, 0) * _turnSpeed;
        transform.localPosition += _directionToMove;
    }
}
