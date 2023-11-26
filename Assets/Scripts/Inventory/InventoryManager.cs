using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private static InventoryManager instance;

    public static InventoryManager Instance
    {
        get { return instance; }
    }

    public int crntHandIndex = 0;

    public List<string> playerInventory;

    public Item[] itemList;

    private void Awake()
    {
        //playerInventory = new List<string>();
    }

    private void Start()
    {
        equipItem(0);
        updateHandItem();
        Debug.Log(playerInventory[0]);
    }

    public void addItem(string itm)
    {
        playerInventory.Add(itm);
    }

    public void removeItem(string itm)
    {
        playerInventory.Remove(itm);
    }

    public void equipItem(int index)
    {
        if (index == crntHandIndex) return;
        if(index > playerInventory.Count - 1) index = playerInventory.Count - 1;
        if(index < 0) index = 0;
        crntHandIndex = index;
        updateHandItem();
    }

    public void equipItemByName(string name)
    {
        if(!playerInventory.Contains(name)) return;
        crntHandIndex = playerInventory.IndexOf(name);
        updateHandItem();
    }

    public void updateHandItem()
    {
        if(playerInventory.Count == 0) return;
        string crntName = playerInventory[crntHandIndex];
        foreach (Item itm in itemList)
        {
            itm.item_container.SetActive(itm.item_name == crntName);
        }
    }
}
