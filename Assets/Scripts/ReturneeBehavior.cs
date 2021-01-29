using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturneeBehavior : MonoBehaviour
{
    float timer = 0;
    string objectFound; 
    bool objectSpawn = false;
    public float recievedDocumentTimer = -5;
    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-8f, 2.5f), 3f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f && objectSpawn == false)
        {
            gameObject.GetComponent<SpawnItem>().spawnItem();
            objectSpawn = true;
        }

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
            GameManager.GetComponent<GameManager>().returneeSpawned = false;
        }
        else if (recievedDocumentTimer < -1)
        {
            recievedDocumentTimer -= Time.deltaTime;
        }
    }
}