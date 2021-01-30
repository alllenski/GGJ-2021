using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ReturneePreFab; 
    public GameObject OwnerPreFab;

    public bool returneeSpawned = true;
    public bool ownerSpawned = false;

    //Timer
    public float phaseOneTimer = 0f;
    public float phaseTwoTimer = 0f;

    public bool phaseOne = true;
    public bool phaseTwo = false;

    // Start is called before the first frame update
    void Start()
    {
        if (phaseOne && returneeSpawned)
        {
            Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
            Debug.Log("Spawn me");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (phaseOneTimer < 10f && phaseOne) 
        {
            phaseOneTimer += Time.deltaTime;
            if (returneeSpawned == false)
            {   
                Instantiate(ReturneePreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
                Debug.Log("I am spawned again");
                returneeSpawned = true;
            }
        }

        else if (phaseOneTimer > 10f)
        {
            Debug.Log("whre is my supersuit");
            if (returneeSpawned == false)
            {
                phaseOne = false;
                Debug.Log("phase two ooga booga");
                phaseTwo = true;
                phaseOneTimer = 0f;
            };         
        }

        if (phaseTwoTimer < 10f && phaseTwo)
        {
            phaseTwoTimer += Time.deltaTime;
            if (ownerSpawned == false)
            {
            Instantiate(OwnerPreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
            Debug.Log("I am owner awo awo");
            ownerSpawned = true;
            }
        }
    }
}
