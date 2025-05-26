using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SimpleFPSController")
        {
            Debug.Log("Colision");
            scoreManager.addScore();
            Destroy(gameObject);
        }
    }
}
