using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public struct spawnedObject
    {
        string spawnedObjectName;
        string spawnedObjectDetails;
        string spawnedObjectColour;
    }

    public List<string> allItems = new List <string>(new string[]
    {
       "Keychain", "Wallet", "Pen", "Glasses", "Umbrella", "Gloves", "Water bottle", "Footwear", "Cutlery", "Jacket" 
    }); 
    
    public List<string> allColours = new List <string>(new string[]
    {
       "Blue", "Yellow", "Red"
    }); 

    public List<string> keyChainDetails = new List <string>(new string[]
    {
        "Just a normal keychain", "A ring for the handle", "It is chained"
    }); 

    public List<string> walletDetails = new List <string>(new string[]
    {
        "Has money", "Has picture", "Empty"
    }); 

    public List<string> penDetails = new List <string>(new string[]
    {
        "Has a cap", "Retractable"
    }); 

    public List<string> glassesDetails = new List <string>(new string[]
    {
        "For shading the eyes", "For Reading"
    }); 

    public List<string> umbrellaDetails = new List <string>(new string[]
    {
        "Automatically folds and unfolds", "Cane for a handle"
    }); 

    public List<string> glovesDetails = new List <string>(new string[]
    {
        "Silky", "Fluffy"
    }); 

    public List<string> waterBottleDetails = new List <string>(new string[]
    {
        "Has a handle", "No handle"
    }); 

    public List<string> footWearDetails = new List <string>(new string[]
    {
        "For casual wear", "Could be used when rainy", "Used for school"
    }); 

    public List<string> cutleryDetails = new List <string>(new string[]
    {
        "It has prongs", "It is round", "It is sharp"
    }); 

    public List<string> jacketDetails = new List <string>(new string[]
    {
        "It has a smooth surface", "It is soft", "It is very fluffy"
    });


    public GameObject prefab;

    public GameObject spawnItem() 
    {
        spawnedObject spawnedItem; 

        GameObject item = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        
        item.GetComponent<ItemDetails>().itemName = allItems[Random.Range(0, allItems.Count - 1)];

        item.GetComponent<ItemDetails>().itemColour = allColours[Random.Range(0, allColours.Count - 1)];
        
        if (item.GetComponent<ItemDetails>().itemName == "Keychain")
        {
            item.GetComponent<ItemDetails>().itemDetails = keyChainDetails[Random.Range(0, keyChainDetails.Count - 1)];
        }
        
        else if (item.GetComponent<ItemDetails>().itemName == "Wallet")
        {
            item.GetComponent<ItemDetails>().itemDetails = walletDetails[Random.Range(0, walletDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Pen")
        {
            item.GetComponent<ItemDetails>().itemDetails = penDetails[Random.Range(0, penDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Glasses")
        {
            item.GetComponent<ItemDetails>().itemDetails = glassesDetails[Random.Range(0, glassesDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Umbrella")
        {
            item.GetComponent<ItemDetails>().itemDetails = umbrellaDetails[Random.Range(0, umbrellaDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Gloves")
        {
            item.GetComponent<ItemDetails>().itemDetails = glovesDetails[Random.Range(0, glovesDetails.Count - 1)];
        }
        
        else if (item.GetComponent<ItemDetails>().itemName == "Waterbottle")
        {
            item.GetComponent<ItemDetails>().itemDetails = waterBottleDetails[Random.Range(0, waterBottleDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Footwear")
        {
            item.GetComponent<ItemDetails>().itemDetails = footWearDetails[Random.Range(0, footWearDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Cutlery")
        {
            item.GetComponent<ItemDetails>().itemDetails = cutleryDetails[Random.Range(0, cutleryDetails.Count - 1)];
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Jacket")
        {
            item.GetComponent<ItemDetails>().itemDetails = jacketDetails[Random.Range(0, jacketDetails.Count - 1)];
        }

        item.GetComponent<LerpMovement>().moveTo(new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y - 3.0f), 2.0f);

        return item;
    }    
}
