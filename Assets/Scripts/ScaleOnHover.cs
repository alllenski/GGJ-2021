using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnHover : MonoBehaviour
{

    void OnMouseOver()
    {
       if (Input.mouseScrollDelta.y > 0 && transform.localScale.x < 2f)
       {
            transform.localScale += new Vector3(0.5f, 0.5f, 0);
       }
       else if (Input.mouseScrollDelta.y < 0 && transform.localScale.x > 1f)
       {    
            transform.localScale -= new Vector3(0.5f, 0.5f, 0);
       }
        
    }

}
