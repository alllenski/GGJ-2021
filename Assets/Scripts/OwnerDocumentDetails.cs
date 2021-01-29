using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnerDocumentDetails : MonoBehaviour
{
  public string objectLost = string.Empty;
  public string objectDetails = string.Empty;
  public string objectColour = string.Empty;
  public string signature = string.Empty;

  public int score = 0;

  void OnMouseDown()
  {
    Debug.Log(objectLost);
    Debug.Log(signature);
  }

}
