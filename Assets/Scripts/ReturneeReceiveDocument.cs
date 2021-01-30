using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturneeReceiveDocument : MonoBehaviour
{
    public float force = 20.0f;
    public bool receiving = false;
    public bool received = false;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (receiving && col.tag == "Returnee Document" && gameObject.GetComponent<ReturneeBehavior>().objectSpawn) 
        {
            if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == string.Empty && col.gameObject.GetComponent<ReturneeDocumentDetails>().objectColour == string.Empty
            && col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == string.Empty){
                // Edits documentObject
                col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost = gameObject.GetComponent<ReturneeBehavior>().objectFound;
                col.gameObject.GetComponent<ReturneeDocumentDetails>().objectColour = gameObject.GetComponent<ReturneeBehavior>().objectColour;
                col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails = gameObject.GetComponent<ReturneeBehavior>().objectDetails;

                gameObject.GetComponent<ReturneeBehavior>().recievedDocumentTimer = 1f;
                received = true;
    
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


