using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesItem : MonoBehaviour
{
    //物體的數據倉庫
    public Item item;
    //背包的數據倉庫
    public ItemList mainItem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {

            if (!mainItem.itemList.Contains(item))
            {
                mainItem.itemList.Add(item);
            }
            item.itemNum += 1;
//Destroy(this.gameObject);
        }
    }
}
