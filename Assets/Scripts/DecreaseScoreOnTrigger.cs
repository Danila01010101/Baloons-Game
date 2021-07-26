using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseScoreOnTrigger : MonoBehaviour
{
    [SerializeField]
    private ScoreCounter _scoreCounter;

    private void OnTriggerEnter()
    {
        _scoreCounter.DecreaseScore();
    }
}
