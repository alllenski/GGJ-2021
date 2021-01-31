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

    public Sprite neutralSprite;
    public Sprite happySprite;
    public Sprite sadSprite;

    public float force = 20.0f;
    private bool receiving = true;

    public bool waitingForObject = false; 

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-6f, 3.2f), 3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = neutralSprite;
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
                gameObject.GetComponent<SpriteRenderer>().sprite = sadSprite;
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
            gameObject.GetComponent<SpriteRenderer>().sprite = happySprite;
            recievedDocumentTimer -= Time.deltaTime;
        }
        else if (recievedDocumentTimer < 0 && recievedDocumentTimer > -1)
        {
            gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-13f, 3.2f), 3f);
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
