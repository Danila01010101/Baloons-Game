using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallThrough : MonoBehaviour
{
    private string _controllable = "Controllable";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_controllable))
        {
            other.GetComponent<Rigidbody>().detectCollisions = false;
            other.GetComponent<FollowPlayer>().SetObjectToFollow(null);
            StartCoroutine(DestroyAfterSeconds(2f, other.gameObject));
        }
    }

    IEnumerator DestroyAfterSeconds(float seconds, GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(objectToDestroy);
    }
}
