using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonador : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        Clonar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clonar()
    {
        Instantiate(obj);
    }
}
