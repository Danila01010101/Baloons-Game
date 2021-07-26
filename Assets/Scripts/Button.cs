using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool _isActive = true;
    private void OnCollisionEnter(Collision collision)
    {
        if (_isActive)
        {
            gameObject.transform.position = gameObject.transform.position + Vector3.down * 0.2f;
            Destroy(collision.gameObject);
            _isActive = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
