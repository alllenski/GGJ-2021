using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    
    public GameObject prefab;

    public void spawnItem() 
    {
        GameObject item = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        item.GetComponent<LerpMovement>().moveTo(new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y - 3.0f), 2.0f);
    }

}
