using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ReturneePreFab; 
    public GameObject OwnerPreFab;

    public List<GameObject> foundObjects = new List<GameObject>();

    public List<string> allNames = new List<string>(new string []
    {
        "Sam", "Allen", "Ma-I", "Matthew", "Miguel", "Jonathan", "Hanz", "Dylan", "Gene", "Jericho", "Claude", "Greg", "Jones", "Royce", "Jake", "Julius"
    });

    public Sprite[] neutralKid;
    public Sprite[] happyKid;
    public Sprite[] sadKid;

    public bool returneeSpawned = true;
    public bool ownerSpawned = false;

    //Timer
    public float phaseOneTimer = 0f;
    public float phaseTwoTimer = 0f;

    public bool phaseOne = true;
    public bool phaseTwo = false;

    public bool gameFinisherIsCalled = false;

    public int random;

    // Start is called before the first frame update
    void Start()
    {
        if (phaseOne && returneeSpawned)
        {
            GameObject returnee = Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
            int random = Random.Range(0, neutralKid.Length);
            returnee.GetComponent<ReturneeBehavior>().neutralSprite = neutralKid[random];
            returnee.GetComponent<ReturneeBehavior>().happySprite = happyKid[random];
            returnee.GetComponent<ReturneeBehavior>().sadSprite = sadKid[random];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (phaseOneTimer < 20f && phaseOne) 
        {
            phaseOneTimer += Time.deltaTime;
            if (returneeSpawned == false)
            {   
                GameObject returnee = Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
                int random = Random.Range(0, neutralKid.Length);
                returnee.GetComponent<ReturneeBehavior>().neutralSprite = neutralKid[random];
                returnee.GetComponent<ReturneeBehavior>().happySprite = happyKid[random];
                returnee.GetComponent<ReturneeBehavior>().sadSprite = sadKid[random];
                returneeSpawned = true;
            }
        }

        else if (phaseOneTimer > 20f)
        {
            if (returneeSpawned == false)
            {
                phaseOne = false;
                phaseTwo = true;
                phaseOneTimer = 0f;
            };         
        }

        if (phaseTwoTimer < 20f && phaseTwo)
        {
            phaseTwoTimer += Time.deltaTime;
            if (ownerSpawned == false && foundObjects.Count != 0)
            {
                GameObject Owner = Instantiate(OwnerPreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
                int random = Random.Range(0, foundObjects.Count - 1);
                int randomName = Random.Range(0, allNames.Count - 1);

                Owner.GetComponent<OwnerBehaviour>().ownerName = allNames[random];
                Owner.GetComponent<OwnerBehaviour>().objectFound = foundObjects[random].GetComponent<ItemDetails>().itemName;
                Owner.GetComponent<OwnerBehaviour>().objectColour = foundObjects[random].GetComponent<ItemDetails>().itemColour;
                Owner.GetComponent<OwnerBehaviour>().objectDetails = foundObjects[random].GetComponent<ItemDetails>().itemDetails;

                random = Random.Range(0, neutralKid.Length);
                Owner.GetComponent<OwnerBehaviour>().neutralSprite = neutralKid[random];
                Owner.GetComponent<OwnerBehaviour>().happySprite = happyKid[random];
                Owner.GetComponent<OwnerBehaviour>().sadSprite = sadKid[random];

                Owner.GetComponent<OwnerReceiveDocument>().receiving = true;
                ownerSpawned = true;
            }
        }
        if (phaseTwoTimer > 20f && gameFinisherIsCalled == false)
        {
            finishTheGame();
            gameFinisherIsCalled = true;
            
        }
    }

    void finishTheGame()
    {
        GameObject[] documents = GameObject.FindGameObjectsWithTag("Owner Document");
        int score = documents.Length;
        Debug.Log("YOUR SCORE IS: " + score);
    }

}
