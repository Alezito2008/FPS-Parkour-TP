using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SimpleFPSController")
        {
            Debug.Log("Colision");
            Destroy(gameObject);
        }
    }
}
