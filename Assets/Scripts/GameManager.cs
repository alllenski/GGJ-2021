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

    public bool returneeSpawned = true;
    public bool ownerSpawned = false;

    //Timer
    public float phaseOneTimer = 0f;
    public float phaseTwoTimer = 0f;

    public bool phaseOne = true;
    public bool phaseTwo = false;

    public int random;

    // Start is called before the first frame update
    void Start()
    {
        if (phaseOne && returneeSpawned)
        {
            Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
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
                Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
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
            if (ownerSpawned == false)
            {
                GameObject Owner = Instantiate(OwnerPreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
                random = Random.Range(0, foundObjects.Count - 1);
                int randomName = Random.Range(0, allNames.Count - 1);

                Owner.GetComponent<OwnerBehaviour>().ownerName = allNames[random];
                Owner.GetComponent<OwnerBehaviour>().objectFound = foundObjects[random].GetComponent<ItemDetails>().itemName;
                Owner.GetComponent<OwnerBehaviour>().objectColour = foundObjects[random].GetComponent<ItemDetails>().itemColour;
                Owner.GetComponent<OwnerBehaviour>().objectDetails = foundObjects[random].GetComponent<ItemDetails>().itemDetails;


                Owner.GetComponent<OwnerReceiveDocument>().receiving = true;
                ownerSpawned = true;
            }
        }
    }
}
