using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerBehaviour : MonoBehaviour
{
    float timer = 0;
    string objectFound; 
    string objectColour;
    string objectDetails;
    public float recievedDocumentTimer = -5;
    GameObject GameManager;

    public float force = 20.0f;
    private bool receiving = true;

    public bool waiting = false; 

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-8f, 2.5f), 3f);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (waiting && receiving && col.tag == "Item")
        {
            Destroy(col.gameObject);
            recievedDocumentTimer = 1f;
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
            Debug.Log("I am gone");
            Destroy(gameObject);
            GameManager.GetComponent<GameManager>().ownerSpawned = false;
        }
        else if (recievedDocumentTimer < -1)
        {
            recievedDocumentTimer -= Time.deltaTime;
        }
    }

}
