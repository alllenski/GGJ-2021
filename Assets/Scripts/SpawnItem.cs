using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;
    void OnMouseDown()
    {
        Instantiate(item, gameObject.transform.position, Quaternion.identity);
    }
}
