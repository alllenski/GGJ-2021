using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturneeReceiveDocument : MonoBehaviour
{
    public float force = 20.0f;
    public bool receiving = false;
    public bool received = false;
    public GameObject detail;
    public Sprite[] details;
    
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

                GameObject instantDetail = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                    col.gameObject.transform.position.y - 0.2f, col.gameObject.transform.position.z), Quaternion.identity);

                int index = 0;

                if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Just a normal keychain")
                {
                    index = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "A ring for the handle")
                {
                    index = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is chained")
                {
                    index = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has money")
                {
                    index = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has picture")
                {
                    index = 4;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Empty")
                {
                    index = 5;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a cap")
                {
                    index = 6;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Retractable")
                {
                    index = 7;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "For shading the eyes")
                {
                    index = 8;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a cover")
                {
                    index = 11;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "No cover")
                {
                    index = 12;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Silky")
                {
                    index = 13;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Fluffy")
                {
                    index = 14;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a handle")
                {
                    index = 15;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "No handle")
                {
                    index = 16;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "For casual wear")
                {
                    index = 17;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Could be used when rainy")
                {
                    index = 18;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Used for school")
                {
                    index = 19;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It has prongs")
                {
                    index = 20;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is round")
                {
                    index = 21;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is sharp")
                {
                    index = 22;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It has a smooth surface")
                {
                    index = 23;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is soft")
                {
                    index = 24;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is very fluffy")
                {
                    index = 25;
                }

                instantDetail.GetComponent<SpriteRenderer>().sprite = details[index];
                instantDetail.transform.parent = col.gameObject.GetComponent<ReturneeDocumentDetails>().transform;

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


