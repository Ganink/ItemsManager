using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ItemModel
{
    public string id;
    public string name;
    public string description;
    public string icon;
    public string maxAmount;
    public ItemType itemType;
}

public enum ItemType
{
    None,
    Potion,
    Gold,
    Gems,
    Sword,
    Shield,
}
