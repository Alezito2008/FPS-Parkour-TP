using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    public void updateScore(int score)
    {
        scoreText.text = $"Score: {score}";
    }

    public void updateHealth(int health)
    {
        healthText.text = $"Health: {health}";
    }
}
