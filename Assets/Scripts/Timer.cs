using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    
    public GameObject GameManager;

    public float firstTimer;
    public float secondTimer;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetComponent<GameManager>().phaseOne)
        {
           firstTimer = GameManager.GetComponent<GameManager>().phaseOneTimer;
           GetComponent<Text>().text = firstTimer.ToString();
        }
        
        else if (GameManager.GetComponent<GameManager>().phaseTwo)
        {
            secondTimer = GameManager.GetComponent<GameManager>().phaseTwoTimer;
            GetComponent<Text>().text = secondTimer.ToString();
        }
    }
}
