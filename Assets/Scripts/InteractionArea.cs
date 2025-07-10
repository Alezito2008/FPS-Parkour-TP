using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public ScoreManager scoreManager;

    public GameObject UIInteractionMessage;
    GameObject currentInteractable = null;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Interactable")) return;
        UIInteractionMessage.SetActive(true);
        currentInteractable = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Interactable")) return;
        UIInteractionMessage.SetActive(false);
        if (currentInteractable == other.gameObject) currentInteractable = null;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            Mercaderia mercaderia = currentInteractable.GetComponent<Mercaderia>();
            if (mercaderia != null)
            {
                scoreManager.addScore(mercaderia.scorePoints);
            }
            Destroy(currentInteractable.gameObject);
            currentInteractable = null;
            UIInteractionMessage.SetActive(false);
        }
    }
}
