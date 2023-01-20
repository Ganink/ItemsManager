using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Greenvillex/Items/New Item")]
public class ItemSO : ScriptableObject
{
    [SerializeField] private ItemModel itemModel;

    public ItemModel GetItemModel()
    {
        return itemModel;
    }
}
