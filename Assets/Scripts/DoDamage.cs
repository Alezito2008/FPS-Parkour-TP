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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SimpleFPSController")
        {
            healthManager.damage();
            Destroy(gameObject);
        }
    }
}
