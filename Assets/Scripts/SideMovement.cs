using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3 _destinationPosition;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }
    private void FixedUpdate()
    {
        transform.localPosition = Vector3.Lerp(_startPosition, _startPosition + _destinationPosition, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
