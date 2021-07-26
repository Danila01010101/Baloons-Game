using UnityEngine;
using UnityEngine.UI;

public class ScoreViewUI : MonoBehaviour
{
    [SerializeField]
    private ScoreCounter _scoreCounter;
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        ScoreCounter.OnScoreChange += UpdateScore;
    }

    private void OnDisable()
    {
        ScoreCounter.OnScoreChange -= UpdateScore;
    }

    private void UpdateScore()
    {
        _scoreText.text = _scoreCounter.score.ToString();
    }
}
