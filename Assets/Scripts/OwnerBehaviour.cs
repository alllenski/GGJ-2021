using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerBehaviour : MonoBehaviour
{
    float timer = 0;
    public string ownerName;
    public string objectFound; 
    public string objectColour;
    public string objectDetails;
    public float recievedDocumentTimer = -5;
    GameObject GameManager;

    
    public float force = 20.0f;
    private bool receiving = true;

    public bool waitingForObject = false; 

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-8f, 2.5f), 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(objectFound);
        if (waitingForObject && receiving && col.tag == "Item") 
        {
            if (col.gameObject.GetComponent<ItemDetails>().itemName == objectFound && 
            col.gameObject.GetComponent<ItemDetails>().itemColour == objectColour && 
            col.gameObject.GetComponent<ItemDetails>().itemDetails == objectDetails)
            {
                Debug.Log(objectFound);
                GameManager.GetComponent<GameManager>().foundObjects.Remove(col.gameObject);
                Destroy(col.gameObject);
                waitingForObject = false;
            }
            else 
            {
                Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
                col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
            }
        }
       
    }

    void Update()
    {
        if (recievedDocumentTimer > 0)
        {
            recievedDocumentTimer -= Time.deltaTime;
        }
        else if (recievedDocumentTimer < 0 && recievedDocumentTimer > -1)
        {
            gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-11.6f, 2.478f), 3f);
            recievedDocumentTimer -= Time.deltaTime;
        }
        else if (recievedDocumentTimer < -2 && recievedDocumentTimer > -5)
        {
            Debug.Log(objectFound);
            Debug.Log(objectColour);
            Debug.Log(objectDetails);
            Destroy(gameObject);
            GameManager.GetComponent<GameManager>().ownerSpawned = false;
        }
        else if (recievedDocumentTimer < -1)
        {
            recievedDocumentTimer -= Time.deltaTime;
        }
    }
    

}
