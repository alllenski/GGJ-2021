using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PreFab; 
    public bool returneeSpawned = true;

    //Timer
    public float phaseOneTimer = 0f;

    public bool phaseOne = true;
    public bool phaseTwo = false;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
        Debug.Log("Spawn me");
    }

    // Update is called once per frame
    void Update()
    {
        if (phaseOneTimer < 10f && phaseOne) 
        {
            phaseOneTimer += Time.deltaTime;
            if (returneeSpawned == false)
            {   
                Instantiate(PreFab, new Vector2(-11f, 2.5f), Quaternion.identity);
                Debug.Log("I am spawned again");
                returneeSpawned = true;
                
            }
        }
        else if (phaseOneTimer > 10f)
        {
            phaseOne = false;
            phaseTwo = true;
            phaseOneTimer = 0;
        }
    }
}
