using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void addScore()
    {
        score+=10;
        uiManager.updateScore(score);
    }

    public void addScore(int scorePoints)
    {
        score += scorePoints;
        uiManager.updateScore(score);
    }
}
