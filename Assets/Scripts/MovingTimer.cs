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
            float result = Mathf.Lerp (-2f, -4.8f, Mathf.InverseLerp(0f, 21f, gm.phaseOneTimer));
            transform.position = new Vector3(result, transform.position.y, transform.position.z);
        }
        else if (gm.phaseTwo)
        {
            float result = Mathf.Lerp (-4.8f, -1.9f, Mathf.InverseLerp(0f, 21f, gm.phaseTwoTimer));
            transform.position = new Vector3(result, transform.position.y, transform.position.z);
        }
    }
}
