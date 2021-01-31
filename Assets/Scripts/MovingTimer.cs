using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTimer : MonoBehaviour
{

    public GameObject gameManager;

    // Update is called once per frame
    void Update()
    {
        var gm = gameManager.GetComponent<GameManager>();
        if (gm.phaseOne)
        {
            float result = Mathf.Lerp (-3.99f, -0.95f, Mathf.InverseLerp(0f, 150f, gm.phaseOneTimer));
            transform.position = new Vector3(result, transform.position.y, transform.position.z);
        }
        else if (gm.phaseTwo)
        {
            float result = Mathf.Lerp (-0.95f, -3.99f, Mathf.InverseLerp(0f, 150f, gm.phaseTwoTimer));
            transform.position = new Vector3(result, transform.position.y, transform.position.z);
        }
    }
}
