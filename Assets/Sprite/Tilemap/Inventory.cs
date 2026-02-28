using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class InvItem
    {

        public string name;
        public Sprite sprite;
        public InvItem(string ItemName, Sprite ItemSprite)
        {
            name = ItemName;
            sprite = ItemSprite;
        }
    
        
    
    }
public class Inventory : MonoBehaviour
{

    public List<InvItem> inventory = new List<InvItem>();

    public Image[] itemSprites;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            itemSprites[i].sprite = inventory[i].sprite;
        }
         if(Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Debug.Log(inventory[i].name);
            }
        }
    }
 
}
