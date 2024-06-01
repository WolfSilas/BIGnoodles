using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopMenu", menuName = "ScriptableObject/New Shop Item")]
public class ShopItemSo : ScriptableObject
{
    public string title;
    public string description;
    public int baseCost;
}

