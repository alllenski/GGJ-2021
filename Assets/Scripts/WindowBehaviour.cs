using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBehaviour : MonoBehaviour
{
    public float force = 20.0f;

    void OnTriggerEnter2D(Collider2D col)
    {
        Vector2 destination = new Vector2(transform.position.x, transform.position.y - 4.0f);
        col.gameObject.GetComponent<LerpMovement>().moveTo(destination, 3f);
    }
}
