using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject UIInteractionMessage;
    public GameObject currentInteractable = null;

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
            Destroy(currentInteractable);
            currentInteractable = null;
            UIInteractionMessage.SetActive(false);
        }
    }
}
