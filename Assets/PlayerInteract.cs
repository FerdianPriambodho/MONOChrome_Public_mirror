using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerInteract : MonoBehaviour
{
    public Transform interactPoint;
    public float interactRange = 0.5f;
    public GameObject DialogCanvas;
    public GameObject dialogWindow;
    Collider2D npc;

    void Update()
    {
        if (npc != null)
        {
            Debug.Log("NPC not null");
            if (CrossPlatformInputManager.GetButtonDown("Melee"))
            {
                dialogWindow.SetActive(true);
            }
        }
        else Debug.Log("NPC is null");
    }

    private void OnDrawGizmosSelected()
    {
        if (interactPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(interactPoint.position, interactRange);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colide with " + collision.name);
        if(LayerMask.LayerToName(collision.gameObject.layer) == "NPC")
        {
            npc = collision;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "NPC")
        {
            npc = null;
        }
    }
}
