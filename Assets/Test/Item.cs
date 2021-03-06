using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Bag/NewItem")]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public int itemNum;
    [TextArea]
    public string itemInfo;
}
