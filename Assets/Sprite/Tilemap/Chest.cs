using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;

//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{

    public Button leaveButton;

    public Button takeButton;

    public List<InvItem> chestContent = new List<InvItem>();
    public GameObject ChestOverlay;
    public Image DisplayImage;
    public TMP_Text DisplayText;
    public InvItem currentItem;
    public Sprite[] sprites;
    public string[] names;

    public int index = 0;
    public Inventory inv;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            chestContent.Add(new InvItem(names[i],sprites[i]));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openChest()
    {
        if(chestContent.Count<=0)
        {
            return;
        }
        leaveButton.onClick.RemoveAllListeners();
        leaveButton.onClick.AddListener(NextItem);

        takeButton.onClick.RemoveAllListeners();
        takeButton.onClick.AddListener(ReceiveItem);

        ChestOverlay.SetActive(true);
        index=0;
        currentItem = chestContent[index];
        DisplayImage.sprite = chestContent[index].sprite;
        DisplayText.text = chestContent[index].name;


        
    }

    public void ConChest()
    {
        if(index>=chestContent.Count)
        {
             ChestOverlay.SetActive(false);
        }
        currentItem = chestContent[index];
        DisplayImage.sprite = chestContent[index].sprite;
        DisplayText.text = chestContent[index].name;

    }


    public void ReceiveItem()
    {
        inv.inventory.Add(currentItem);       
        chestContent.Remove(chestContent[index]);
        
 
        ConChest();


    }
    public void NextItem()
    {
        index+=1; 
        ConChest();
    }




}
