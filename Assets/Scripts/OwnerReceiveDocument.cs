using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerReceiveDocument : MonoBehaviour
{
    public float force = 20.0f;
    private bool receiving = true;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (receiving && col.tag == "Document")
        {
            if (col.gameObject.GetComponent<OwnerDocumentDetails>().signature == string.Empty){
                // Edits documentObject
                col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost = "Hatdog";
                col.gameObject.GetComponent<OwnerDocumentDetails>().signature = "BritneyBeach";
                col.gameObject.GetComponent<OwnerDocumentDetails>().score = 1;
        
                gameObject.GetComponent<OwnerBehaviour>().recievedDocumentTimer = 1f;
            }
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }  
        else
        {
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }   
    }
}


