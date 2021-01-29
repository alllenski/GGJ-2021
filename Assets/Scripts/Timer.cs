using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    
    public GameObject GameManager;

    public float timer;

    // Update is called once per frame
    void Update()
    {
        timer = GameManager.GetComponent<GameManager>().phaseOneTimer;
        GetComponent<Text>().text = timer.ToString();
    }
}
