using UnityEngine;

public class IncreaseScoreOnTrigger : MonoBehaviour
{
    [SerializeField]
    private ScoreCounter _scoreCounter;

    private void OnTriggerEnter()
    {
        _scoreCounter.IncreaseScore();
    }
}
