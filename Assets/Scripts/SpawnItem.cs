using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject item;
    void OnMouseDown()
    {
        Instantiate(item, gameObject.transform.position, Quaternion.identity);
    }
=======
   
    public GameObject prefab;

    void spawnItem() 
    {
        GameObject item = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        item.GetComponent<LerpMovement>().moveTo(new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y - 3.0f), 2.0f);
    }

>>>>>>> 1f061d4253e27b4767188caf3cf5e8bc83948cd0
}
