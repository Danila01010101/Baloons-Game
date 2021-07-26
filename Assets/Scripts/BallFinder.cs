using UnityEngine;

public class BallFinder : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectToFollow;

    private void Start()
    {
        if (_objectToFollow != null)
            gameObject.GetComponent<FollowPlayer>().SetObjectToFollow(_objectToFollow);
    }

    private void OnCollisionEnter(Collision collision)
    {
        FollowPlayer _collisionFollowPlayer = collision.gameObject.GetComponent<FollowPlayer>();
        if (collision.gameObject.CompareTag("Controllable") && _collisionFollowPlayer.GetObjectToFollow() == null)
        {
            collision.gameObject.GetComponent<BallFinder>()._objectToFollow = _objectToFollow;
            _collisionFollowPlayer.SetObjectToFollow(_objectToFollow);
        }
    }

}
