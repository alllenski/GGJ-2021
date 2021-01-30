using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetails : MonoBehaviour
{
    string itemName = "hatdog";
    string itemDetails; 
    string itemColour;

    void OnMouseDown()
    {
        Debug.Log(itemName);
    }

}
