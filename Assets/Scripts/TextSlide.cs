using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextSlide : MonoBehaviour
{
    public List<string> slides;
    public Text text;
    private int currentSlide = 0;

    void Start()
    {
        text.text = slides[currentSlide];
    }

    public void NextSlide()
    {
        currentSlide++;
        if (currentSlide == slides.Count)
        {
            SceneManager.LoadScene(sceneName:"Game");
        }
        text.text = slides[currentSlide];
    }
}
