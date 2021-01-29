using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{

    public float speed = 8f;
 
    public bool paused = false;
    private Vector2 start;
    private Vector2 destination;
    private float fraction = 0; 
 
    public void moveTo (Vector2 des, float duration)
    {
        start = new Vector2(transform.position.x, transform.position.y);
        destination = des;
        fraction = duration;
    } 
    // Update is called once per frame
    void Update()
    {
        if (fraction > 0 && !paused) {
            fraction -= Time.deltaTime * speed;
            transform.position = Vector2.Lerp(transform.position, destination, speed * Time.deltaTime);
        }
    }

}
