using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReturneeDocument : MonoBehaviour
{
    public GameObject document;
    public GameObject GameManager; 

    void OnMouseDown()
    {

        if (GameManager.GetComponent<GameManager>().phaseOne)
        {
            Instantiate(document, gameObject.transform.position, Quaternion.identity);
        }
        else {
            Debug.Log("You do not need this for now.");
        }
    }

}