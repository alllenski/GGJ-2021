using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    public Sprite[] sprites;
    
    public AudioClip[] clips;

    public struct spawnedObject
    {
        string spawnedObjectName;
        string spawnedObjectDetails;
        string spawnedObjectColour;
    }

    private List<string> allItems = new List <string>(new string[]
    {
       "Keychain", "Wallet", "Pen", "Glasses", "Umbrella", "Gloves", "Water bottle", "Footwear", "Cutlery", "Jacket" 
    }); 
    
    private List<string> allColours = new List <string>(new string[]
    {
       "Blue", "Green", "Red"
    }); 

    private List<string> keyChainDetails = new List <string>(new string[]
    {
        "Just a normal keychain", "A ring for the handle", "It is chained"
    }); 

    private List<string> walletDetails = new List <string>(new string[]
    {
        "Has money", "Has picture", "Empty"
    }); 

    private List<string> penDetails = new List <string>(new string[]
    {
        "Has a cap", "Retractable"
    }); 

    private List<string> glassesDetails = new List <string>(new string[]
    {
        "For shading the eyes", "For Reading"
    }); 

    private List<string> umbrellaDetails = new List <string>(new string[]
    {
        "Has a cover", "No cover"
    }); 

    private List<string> glovesDetails = new List <string>(new string[]
    {
        "Silky", "Fluffy"
    }); 

    private List<string> waterBottleDetails = new List <string>(new string[]
    {
        "Has a handle", "No handle"
    }); 

    private List<string> footWearDetails = new List <string>(new string[]
    {
        "For casual wear", "Could be used when rainy", "Used for school"
    }); 

    private List<string> cutleryDetails = new List <string>(new string[]
    {
        "It has prongs", "It is round", "It is sharp"
    }); 

    private List<string> jacketDetails = new List <string>(new string[]
    {
        "It has a smooth surface", "It is soft", "It is very fluffy"
    });


    public GameObject prefab;

    public GameObject spawnItem() 
    {
        spawnedObject spawnedItem; 

        GameObject item = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        
        SpriteRenderer spriteRenderer = item.GetComponent<SpriteRenderer>() as SpriteRenderer;
        AudioClip audio = clips[0];
      
        item.GetComponent<ItemDetails>().itemName = allItems[Random.Range(0, allItems.Count - 1)];

        item.GetComponent<ItemDetails>().itemColour = allColours[Random.Range(0, allColours.Count - 1)];
        
        if (item.GetComponent<ItemDetails>().itemName == "Keychain")
        {
            audio = clips[1];
            item.GetComponent<ItemDetails>().itemDetails = keyChainDetails[Random.Range(0, keyChainDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Just a normal keychain")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[15];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[16];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[17];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "A ring for the handle")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[18];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[19];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[20];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "It is chained")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[21];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[22];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[23];
                }
            }
        }
        
        else if (item.GetComponent<ItemDetails>().itemName == "Wallet")
        {
            audio = clips[0];
            item.GetComponent<ItemDetails>().itemDetails = walletDetails[Random.Range(0, walletDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Has money")
            {
                spriteRenderer.sprite = sprites[67];
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Has picture")
            {
                spriteRenderer.sprite = sprites[68];
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Empty")
            {
                spriteRenderer.sprite = sprites[69];
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Pen")
        {
            audio = clips[0];
            item.GetComponent<ItemDetails>().itemDetails = penDetails[Random.Range(0, penDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Has a cap")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[36];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[37];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[38];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Retractable")
            {
                audio = clips[11];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[39];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[40];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[41];
                }
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Glasses")
        {
            audio = clips[0];
            item.GetComponent<ItemDetails>().itemDetails = glassesDetails[Random.Range(0, glassesDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
            {
                spriteRenderer.sprite = sprites[51];
            }
            else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
            {
                spriteRenderer.sprite = sprites[52];
            }
            else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
            {
                spriteRenderer.sprite = sprites[53];
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Umbrella")
        {
            item.GetComponent<ItemDetails>().itemDetails = umbrellaDetails[Random.Range(0, umbrellaDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Has a cover")
            {
                audio = clips[11];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[60];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[61];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[62];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "No cover")
            {
                audio = clips[12];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[63];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[64];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[65];
                }
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Gloves")
        {
            item.GetComponent<ItemDetails>().itemDetails = glovesDetails[Random.Range(0, glovesDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Silky")
            {
                audio = clips[6];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[42];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[43];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[44];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Fluffy")
            {
                audio = clips[7];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[30];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[31];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[32];
                }
            }
        }
        
        else if (item.GetComponent<ItemDetails>().itemName == "Water bottle")
        {
            audio = clips[2];
            item.GetComponent<ItemDetails>().itemDetails = waterBottleDetails[Random.Range(0, waterBottleDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "Has a handle")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[54];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[55];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[56];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "No handle")
            {
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[57];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[58];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[59];
                }
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Footwear")
        {
            item.GetComponent<ItemDetails>().itemDetails = footWearDetails[Random.Range(0, footWearDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "For casual wear")
            {
                audio = clips[13];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[45];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[46];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[47];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Could be used when rainy")
            {
                audio = clips[5];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[3];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[4];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[5];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "Used for school")
            {
                audio = clips[4];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[0];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[1];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[2];
                }
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Cutlery")
        {
            item.GetComponent<ItemDetails>().itemDetails = cutleryDetails[Random.Range(0, cutleryDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "It has prongs")
            {
                audio = clips[14];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[9];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[10];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[11];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "It is round")
            {
                audio = clips[14];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[48];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[49];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[50];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "It is sharp")
            {
                audio = clips[8];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[24];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[25];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[26];
                }
            }
        }

        else if (item.GetComponent<ItemDetails>().itemName == "Jacket")
        {
            item.GetComponent<ItemDetails>().itemDetails = jacketDetails[Random.Range(0, jacketDetails.Count - 1)];
            if (item.GetComponent<ItemDetails>().itemDetails == "It has a smooth surface")
            {
                audio = clips[9];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[27];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[28];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[29];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "It is soft")
            {
                audio = clips[6];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[6];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[7];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[8];
                }
            }
            else if (item.GetComponent<ItemDetails>().itemDetails == "It is very fluffy")
            {
                audio = clips[7];
                if (item.GetComponent<ItemDetails>().itemColour == "Blue") 
                {
                    spriteRenderer.sprite = sprites[12];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Green") 
                {
                    spriteRenderer.sprite = sprites[13];
                }
                else if (item.GetComponent<ItemDetails>().itemColour == "Red") 
                {
                    spriteRenderer.sprite = sprites[14];
                }
            }
        }

        item.GetComponent<PlayAudio>().audioClip = audio;
        item.GetComponent<LerpMovement>().moveTo(new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y - 3.0f), 2.0f);

        return item;
    }    
}
