using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New MainItem", menuName = "Bag/New MainItem")]
public class ItemList : ScriptableObject
{
    public List<Item> itemList = new List<Item>();

}
