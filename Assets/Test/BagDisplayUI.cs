using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagDisplayUI : MonoBehaviour
{
    //��ҼҦ�
    static BagDisplayUI bagDisplayUI;
    private void Awake()
    {
        if (bagDisplayUI != null)
        {
            Destroy(this);

        }
        bagDisplayUI = this;

    }
    //�C���C���Ұʫe�A�ʺA����s�I�]UI����
    private void OnEnable()
    {
        updateItemToUI();
    }
    //�I�]�ƾڭܮw�B��l������w�s��B�MUI����ܪ��餸����������
    public ItemList mainItem;
    public Grid gridPrefab;
    public GameObject myBag;

    /// <summary>
    /// �bUI���N�@�Ӫ��骺�ƾڭܮw��ܥX��
    /// </summary>
    /// <param name="item"></param>
    public static void insertItemToUI(Item item)
    {

        Grid grid = Instantiate(bagDisplayUI.gridPrefab, bagDisplayUI.myBag.transform);
        //grid.gridImage.sprite = item.itemImage;
        //grid.girdNum.text = item.itemNum.ToString();

    }

    /// <summary>
    /// �N�I�]�ƾڭܮw���Ҧ�������ܦbUI�W
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
