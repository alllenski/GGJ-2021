using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturneeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<LerpMovement>().moveTo(new Vector2(-8f, 2.5f), 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
