using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnReturneeDocument : MonoBehaviour
{
    public GameObject document;
    void OnMouseDown()
    {
        Instantiate(document, gameObject.transform.position, Quaternion.identity);
    }

}