using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    private int currentScore = 0;
             
    public void ScoreHit(int pointForKill)
    {
        currentScore += pointForKill;
        _scoreText.text = "Score: " + currentScore.ToString();
    }
}
