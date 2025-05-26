using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Mercaderia mercaderia;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderia = GetComponent<Mercaderia>();
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
