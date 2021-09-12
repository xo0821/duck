using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagDisplayUI : MonoBehaviour
{
    //單例模式
    static BagDisplayUI bagDisplayUI;
    private void Awake()
    {
        if (bagDisplayUI != null)
        {
            Destroy(this);

        }
        bagDisplayUI = this;

    }
    //每次遊戲啟動前，動態的更新背包UI元素
    private void OnEnable()
    {
        updateItemToUI();
    }
    //背包數據倉庫、格子中物體預製體、和UI中顯示物體元素的父元素
    public ItemList mainItem;
    public Grid gridPrefab;
    public GameObject myBag;

    /// <summary>
    /// 在UI中將一個物體的數據倉庫顯示出來
    /// </summary>
    /// <param name="item"></param>
    public static void insertItemToUI(Item item)
    {

        Grid grid = Instantiate(bagDisplayUI.gridPrefab, bagDisplayUI.myBag.transform);
        //grid.gridImage.sprite = item.itemImage;
        //grid.girdNum.text = item.itemNum.ToString();

    }

    /// <summary>
    /// 將背包數據倉庫中所有物體顯示在UI上
    /// </summary>
    public static void updateItemToUI()
    {
        for (int i = 0; i < bagDisplayUI.myBag.transform.childCount; i++)
        {
            Destroy(bagDisplayUI.myBag.transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < bagDisplayUI.mainItem.itemList.Count; i++)
        {
            insertItemToUI(bagDisplayUI.mainItem.itemList[i]);
        }
    }
}
