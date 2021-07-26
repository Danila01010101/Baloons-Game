using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score { get; private set; }
    public delegate void ScoreChanged();
    public static event ScoreChanged OnScoreChange;

    public void IncreaseScore()
    {
        score += 1;
        OnScoreChange();
    }
    
    public void DecreaseScore()
    {
        score -= 1;
        OnScoreChange();
    }
    
    public void MultiplyScore()
    {
        score *= 2;
        OnScoreChange();
    }
}
