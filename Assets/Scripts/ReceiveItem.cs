using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveItem : MonoBehaviour
{

    public float force = 20.0f;
    private bool receiving = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (receiving)
        {
            Destroy(col.gameObject);
        }  
        else
        {
            
            Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
            col.gameObject.GetComponent<DragTransform>().dragging = false;
            col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 2f);
            
        }   
    }

}
