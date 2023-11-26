using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string item_name;
    public GameObject item_container;
    [TextArea] public string item_desc;
}
