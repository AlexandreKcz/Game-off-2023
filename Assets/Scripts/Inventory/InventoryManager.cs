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

    [SerializeField] private int crntHandIndex = 0;

    [SerializeField] private List<string> playerInventory;

    [SerializeField] private Item[] itemList;

    [SerializeField] private Animator _itemAnim;

    private bool _isSwitching = false;

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

    public void equipItem(int index, bool fromKeyboard = false)
    {
        Debug.Log(crntHandIndex);
        if (index == crntHandIndex) return;
        if (_isSwitching) return;
        if(index > playerInventory.Count - 1) return;
        if(index < 0) return;
        crntHandIndex = index;
        _itemAnim.SetTrigger("ItemDown");
        StartCoroutine(delayedHandUpdateForAnim());
    }

    public void equipItemByName(string name)
    {
        if (!playerInventory.Contains(name)) return;
        crntHandIndex = playerInventory.IndexOf(name);
        _itemAnim.SetTrigger("ItemDown");
        StartCoroutine(delayedHandUpdateForAnim());
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

    public void animTrigger()
    {
        _itemAnim.SetTrigger("ItemDown");
    }

    private IEnumerator delayedHandUpdateForAnim()
    {
        _isSwitching = true;
        yield return new WaitForSeconds(.35f);
        updateHandItem();
        yield return new WaitForSeconds(.15f);
        _isSwitching = false;
    }
}
