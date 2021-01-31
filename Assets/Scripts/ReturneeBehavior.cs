using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturneeBehavior : MonoBehaviour
{
    float timer = 0;
    
    public string objectFound; 
    public string objectColour;
    public string objectDetails;

    public Sprite neutralSprite;
    public Sprite happySprite;
    public Sprite sadSprite;

    public bool objectSpawn = false;
    public float recievedDocumentTimer = -5;
    GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-6f, 3.2f), 3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = sadSprite;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f && objectSpawn == false)
        {
            GameObject itemReturnee = gameObject.GetComponent<SpawnItem>().spawnItem();
            objectFound = itemReturnee.GetComponent<ItemDetails>().itemName;
            objectColour = itemReturnee.GetComponent<ItemDetails>().itemColour;
            objectDetails = itemReturnee.GetComponent<ItemDetails>().itemDetails;
            
            gameObject.GetComponent<ReturneeReceiveDocument>().receiving = true;

            GameManager.GetComponent<GameManager>().foundObjects.Add(itemReturnee);

            objectSpawn = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = neutralSprite;
        }

        if (recievedDocumentTimer > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = happySprite;
            gameObject.GetComponent<ReturneeReceiveDocument>().receiving = false;
            recievedDocumentTimer -= Time.deltaTime;
        }
        else if (recievedDocumentTimer < 0 && recievedDocumentTimer > -1)
        {
            gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-13f, 3.2f), 3f);
            recievedDocumentTimer -= Time.deltaTime;
        }
        else if (recievedDocumentTimer < -2 && recievedDocumentTimer > -5)
        {
            Destroy(gameObject);
            gameObject.GetComponent<ReturneeReceiveDocument>().received = false;
            GameManager.GetComponent<GameManager>().returneeSpawned = false;
        }
        else if (recievedDocumentTimer < -1)
        {
            recievedDocumentTimer -= Time.deltaTime;
        }
    }

}