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
    public Sprite[] losts;
    public Sprite[] details;
    public Sprite[] colors;

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
                GameObject instantColor = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                    col.gameObject.transform.position.y - 0.12f, col.gameObject.transform.position.z), Quaternion.identity);
                GameObject instantLosts = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                    col.gameObject.transform.position.y - 0.6f, col.gameObject.transform.position.z), Quaternion.identity);

                int indexLost = 0;

                if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Keychain")
                {
                    indexLost = 0;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Pen")
                {
                    indexLost = 1;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Wallet")
                {
                    indexLost = 2;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Glasses")
                {
                    indexLost = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Umbrella")
                {
                    indexLost = 4;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Gloves")
                {
                    indexLost = 5;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Water bottle")
                {
                    indexLost = 6;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Footwear")
                {
                    indexLost = 7;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Cutlery")
                {
                    indexLost = 8;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectLost == "Jacket")
                {
                    indexLost = 9;
                }

                int indexColor = 0;

                if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectColour == "Blue")
                {
                    indexColor = 0;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectColour == "Green")
                {
                    indexColor = 1;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectColour == "Red")
                {
                    indexColor = 2;
                }

                int indexDetail = 0;

                if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Just a normal keychain")
                {
                    indexDetail = 0;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "A ring for the handle")
                {
                    indexDetail = 1;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is chained")
                {
                    indexDetail = 2;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has money")
                {
                    indexDetail = 3;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has picture")
                {
                    indexDetail = 4;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Empty")
                {
                    indexDetail = 5;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a cap")
                {
                    indexDetail = 6;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Retractable")
                {
                    indexDetail = 7;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "For shading the eyes")
                {
                    indexDetail = 8;
                }   
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a cover")
                {
                    indexDetail = 11;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "No cover")
                {
                    indexDetail = 12;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Silky")
                {
                    indexDetail = 13;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Fluffy")
                {
                    indexDetail = 14;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Has a handle")
                {
                    indexDetail = 15;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "No handle")
                {
                    indexDetail = 16;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "For casual wear")
                {
                    indexDetail = 17;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Could be used when rainy")
                {
                    indexDetail = 18;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "Used for school")
                {
                    indexDetail = 19;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It has prongs")
                {
                    indexDetail = 20;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is round")
                {
                    indexDetail = 21;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is sharp")
                {
                    indexDetail = 22;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It has a smooth surface")
                {
                    indexDetail = 23;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is soft")
                {
                    indexDetail = 24;
                }
                else if (col.gameObject.GetComponent<ReturneeDocumentDetails>().objectDetails == "It is very fluffy")
                {
                    indexDetail = 25;
                }
                else 
                {
                    indexDetail = 9;
                }

                instantDetail.GetComponent<SpriteRenderer>().sprite = details[indexDetail];
                instantDetail.transform.parent = col.gameObject.GetComponent<ReturneeDocumentDetails>().transform;
                instantColor.GetComponent<SpriteRenderer>().sprite = details[indexColor];
                instantColor.transform.parent = col.gameObject.GetComponent<ReturneeDocumentDetails>().transform;
                instantLosts.GetComponent<SpriteRenderer>().sprite = details[indexLost];
                instantLosts.transform.parent = col.gameObject.GetComponent<ReturneeDocumentDetails>().transform;

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


