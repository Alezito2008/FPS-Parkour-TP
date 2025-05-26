using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public void updateScore(int score)
    {
        scoreText.text = $"Score: {score}";
    }
}
