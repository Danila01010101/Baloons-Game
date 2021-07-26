using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyScoreOnTrigger : MonoBehaviour
{
    [SerializeField]
    private ScoreCounter _scoreCounter;

    private bool _isRevardTaken = false;

    private void OnTriggerEnter()
    {
        if (!_isRevardTaken)
        {
            _scoreCounter.MultiplyScore();
            _isRevardTaken = true;
        }
    }
}
