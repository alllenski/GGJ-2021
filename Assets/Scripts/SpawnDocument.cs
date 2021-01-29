using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDocument : MonoBehaviour
{

    public GameObject document;
    void OnMouseDown()
    {
        Instantiate(document, gameObject.transform.position, Quaternion.identity);
    }

}
