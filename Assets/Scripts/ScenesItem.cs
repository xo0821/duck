using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesItem : MonoBehaviour
{
    //物體的數據倉庫
    public Item item;
    //背包的數據倉庫
    public ItemList itemList;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {

            if (!itemList.itemList.Contains(item))
            {
                itemList.itemList.Add(item);
            }
            item.itemNum += 1;
            Debug.Log(item.itemNum);
        }
    }

}
