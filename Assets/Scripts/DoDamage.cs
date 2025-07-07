    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{

    public HealthManager healthManager;

    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SimpleFPSController")
        {
            healthManager.damage();
            Destroy(gameObject);
        }
    }
}
