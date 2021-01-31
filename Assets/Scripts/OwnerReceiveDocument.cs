using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerReceiveDocument : MonoBehaviour
{
    public float force = 20.0f;
    public bool receiving = false;
    public GameObject detail;
    public Sprite[] details;
    public Sprite[] losts;
    public Sprite[] colors;
    public Sprite[] names;

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

                gameObject.GetComponent<OwnerBehaviour>().waitingForObject = true;

                //GameObject instantDetail = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                //    col.gameObject.transform.position.y - 0.2f, col.gameObject.transform.position.z), Quaternion.identity);
                //GameObject instantColor = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                //    col.gameObject.transform.position.y - 0.12f, col.gameObject.transform.position.z), Quaternion.identity);
                GameObject instantLosts = Instantiate(detail, new Vector3(col.gameObject.transform.position.x + 0.1f, 
                    col.gameObject.transform.position.y - 0.6f, col.gameObject.transform.position.z), Quaternion.identity);

                int indexLost = 0;

                if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Keychain")
                {
                    indexLost = 0;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Pen")
                {
                    indexLost = 1;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Wallet")
                {
                    indexLost = 2;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Glasses")
                {
                    indexLost = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Umbrella")
                {
                    indexLost = 4;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Gloves")
                {
                    indexLost = 5;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Water bottle")
                {
                    indexLost = 6;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Footwear")
                {
                    indexLost = 7;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Cutlery")
                {
                    indexLost = 8;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectLost == "Jacket")
                {
                    indexLost = 9;
                }

                int indexColor = 0;

                if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour == "Blue")
                {
                    indexColor = 0;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour == "Green")
                {
                    indexColor = 1;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectColour == "Red")
                {
                    indexColor = 2;
                }

                int indexDetail = 0;

                if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Just a normal keychain")
                {
                    indexDetail = 0;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "A ring for the handle")
                {
                    indexDetail = 1;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It is chained")
                {
                    indexDetail = 2;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Has money")
                {
                    indexDetail = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Has picture")
                {
                    indexDetail = 4;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Empty")
                {
                    indexDetail = 5;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Has a cap")
                {
                    indexDetail = 6;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Retractable")
                {
                    indexDetail = 7;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "For shading the eyes")
                {
                    indexDetail = 8;
                }   
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Has a cover")
                {
                    indexDetail = 11;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "No cover")
                {
                    indexDetail = 12;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Silky")
                {
                    indexDetail = 13;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Fluffy")
                {
                    indexDetail = 14;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Has a handle")
                {
                    indexDetail = 15;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "No handle")
                {
                    indexDetail = 16;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "For casual wear")
                {
                    indexDetail = 17;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Could be used when rainy")
                {
                    indexDetail = 18;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Used for school")
                {
                    indexDetail = 19;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It has prongs")
                {
                    indexDetail = 20;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It is round")
                {
                    indexDetail = 21;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It is sharp")
                {
                    indexDetail = 22;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It has a smooth surface")
                {
                    indexDetail = 23;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It is soft")
                {
                    indexDetail = 24;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "It is very fluffy")
                {
                    indexDetail = 25;
                }
                else 
                {
                    indexDetail = 9;
                }


                // instantDetail.GetComponent<SpriteRenderer>().sprite = details[indexDetail];
                // instantDetail.transform.parent = col.gameObject.GetComponent<OwnerDocumentDetails>().transform;
                // instantColor.GetComponent<SpriteRenderer>().sprite = details[indexColor];
                // instantColor.transform.parent = col.gameObject.GetComponent<OwnerDocumentDetails>().transform;
                instantLosts.GetComponent<SpriteRenderer>().sprite = details[indexLost];
                instantLosts.transform.parent = col.gameObject.GetComponent<OwnerDocumentDetails>().transform;
                
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

                int indexName = 0;

                if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Sam")
                {
                    indexName = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Allen")
                {
                    indexName = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Ma-I")
                {
                    indexName = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Matthew")
                {
                    indexName = 3;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Miguel")
                {
                    indexName = 4;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Jonathan")
                {
                    indexName = 5;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Hanz")
                {
                    indexName = 6;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Dylan")
                {
                    indexName = 7;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Gene")
                {
                    indexName = 8;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Jericho")
                {
                    indexName = 11;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Claude")
                {
                    indexName = 12;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Greg")
                {
                    indexName = 13;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Jones")
                {
                    indexName = 14;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Royce")
                {
                    indexName = 12;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Jake")
                {
                    indexName = 13;
                }
                else if (col.gameObject.GetComponent<OwnerDocumentDetails>().objectDetails == "Julius")
                {
                    indexName = 14;
                }
            }
        }

        else 
        {
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
        }
    }
}


