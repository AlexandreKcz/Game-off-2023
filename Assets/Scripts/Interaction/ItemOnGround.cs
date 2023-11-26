using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnGround : Interactable
{
    [SerializeField] private string item_name;

    private InventoryManager _inventoryManager;

    private void Start()
    {
        _inventoryManager = InventoryManager.Instance;

        if(_inventoryManager == null)
        {
            Debug.LogWarning("inventory manager instance is null on item on ground : " + this.gameObject.name + " setting from findObject");
            _inventoryManager = FindObjectOfType<InventoryManager>();
        }
    }

    public override void interaction(GameObject source)
    {
        _inventoryManager.addItem(item_name);
        _inventoryManager.equipItemByName(item_name);
        Destroy(this.gameObject);
    }
}
