using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextSlide : MonoBehaviour
{
    public Sprite[] slides;
    public AudioClip audioClip;
    private int currentSlide = 0;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = slides[currentSlide];
    }

    void OnMouseDown()
    {
        currentSlide++;
        if (currentSlide == 3)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Stop();
            audioSource.PlayOneShot(audioClip);
        }
        if (currentSlide == slides.Length)
        {
            SceneManager.LoadScene(sceneName:"Game");
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = slides[currentSlide];
    }
}
