using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOwnerDocument : MonoBehaviour
{
    public GameObject document;
    public GameObject GameManager;

    void OnMouseDown()
    {
        if (GameManager.GetComponent<GameManager>().phaseTwo)
        {
            Instantiate(document, gameObject.transform.position, Quaternion.identity);
        }
        else {
            Debug.Log("You do not need this for now.");
        }
    }

}