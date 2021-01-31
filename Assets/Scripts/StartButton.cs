using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    public Sprite idleSprite;
    public Sprite hoverSprite;

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName:"Intro");
    }

    void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = hoverSprite;
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = idleSprite;
    }

}
