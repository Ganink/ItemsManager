using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Greenvillex/Items/Item Database"))]
public partial class ItemDatabase : ScriptableObject
{
    [SerializeField] private List<ItemSO> ItemDB;

    public ItemSO GetItem(int index)
    {
        var selectedItem = ItemDB[index];
        if (selectedItem == null)
        {
            Debug.LogError("[ItemDatabase]: Item Not Found!");
        }
        return selectedItem;
    }

    public List<ItemSO> GetItems()
    {
        return ItemDB;
    }
}


