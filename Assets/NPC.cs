using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NPC : MonoBehaviour
{
    public Animator animator;
    public Transform interactPoint;
    public float interactRange = 0.5f;
    public GameObject dialog;

    Collider2D Player;

    //Draw interact Circle
    private void OnDrawGizmosSelected()
    {
        if (interactPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(interactPoint.position, interactRange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colide with " + collision.name);
        if (LayerMask.LayerToName(collision.gameObject.layer) == "NPC")
        {
            Player = collision;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (LayerMask.LayerToName(collision.gameObject.layer) == "NPC")
        {
            Player = null;
        }
    }

}
