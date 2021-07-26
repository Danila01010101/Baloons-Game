using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    private int _health;

    public delegate void HealthChanged();
    public static event HealthChanged OnHealthChanged;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        _health -= 1;
        if (_health <= 0)
            Destroy(gameObject);
        if (OnHealthChanged != null)
            OnHealthChanged();
    }

    public int GetHealth()
    {
        return _health;
    }
}
