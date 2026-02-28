using UnityEngine;


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

    public InvItem[] inventory;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
