using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UICtrl : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    public float UseRate = 2f;
    private float nextUse = 0.0f;
    int ItemCount;
    public ItemList itemList;
    public GameObject ShowCurrentItemInfoUi;
    public GameObject Bag;
    public static bool CIinfouiIsActive;
    [SerializeField]
    Image CurrentImage;
    [SerializeField]
    Text[] Currenttext = new Text[3];
    void Start()
    {
        CIinfouiIsActive = true;
        ShowCurrentItemInfoUi.active = CIinfouiIsActive;
        ItemCount = 4;
    }

    public void UseCurrentItem() {
        if (Time.time > nextUse)
        {
            nextUse = Time.time + UseRate;
            itemList.itemList[ItemCount].itemNum -= 1;
        }
}
    private bool pointerDown;
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }
    void Update()
    {
        if (pointerDown) {
            UseCurrentItem();
        }
        CurrentImage.sprite = itemList.itemList[ItemCount].itemImage;
        Currenttext[0].text = itemList.itemList[ItemCount].itemName;
        Currenttext[1].text = itemList.itemList[ItemCount].itemInfo;
        Currenttext[2].text = itemList.itemList[ItemCount].itemNum.ToString();

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDown = false;
    }

    void BagClose_Open() {
        Bag.active = !Bag.active;
    }

}
