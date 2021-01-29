using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD:Assets/Scripts/FillDocument.cs
public class FillDocument : MonoBehaviour
=======
public class ReturneeBehavior : MonoBehaviour
>>>>>>> 1f061d4253e27b4767188caf3cf5e8bc83948cd0:Assets/Scripts/ReturneeBehavior.cs
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
