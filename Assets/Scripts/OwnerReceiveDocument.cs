using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerReceiveDocument : MonoBehaviour
{
    public float force = 20.0f;
    public bool receiving = false;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (receiving && col.tag == "Owner Document")
        {
            if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == string.Empty && col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour == string.Empty
            && col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == string.Empty)
            {
                // Edits documentObject
                col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost = gameObject.GetComponent<OwnerBehaviour>().objectFound;
                col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour = gameObject.GetComponent<OwnerBehaviour>().objectColour;
                col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails = gameObject.GetComponent<OwnerBehaviour>().objectDetails;
                Debug.Log("not waiting for object");
                gameObject.GetComponent<OwnerBehaviour>().waitingForObject = true;
                Debug.Log("now waiting for object");
                
            }
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }  
        else
        {
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }   

        if  (gameObject.GetComponent<OwnerBehaviour>().waitingForObject == false && receiving && col.tag == "Owner Document") 
        {
            if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == gameObject.GetComponent<OwnerBehaviour>().objectFound &&
            col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour == gameObject.GetComponent<OwnerBehaviour>().objectColour && 
            col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == gameObject.GetComponent<OwnerBehaviour>().objectDetails) 
            {
                col.gameObject.GetComponent<OwnerDocumentDetails>().signature = gameObject.GetComponent<OwnerBehaviour>().ownerName;
                gameObject.GetComponent<OwnerBehaviour>().recievedDocumentTimer = 1f;
            }
        }

        else 
        {
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }
    }
}


