using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesItem : MonoBehaviour
{
    //���骺�ƾڭܮw
    public Item item;
    //�I�]���ƾڭܮw
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
