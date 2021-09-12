using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    static int currentDataInt;
    Data[] datas = new Data[9] {
        new Data(){ Name = "白巧克力",Count = 0,Describe = "一包已打開的白色巧克力，到期日被劃掉" },
        new Data(){ Name = "黑巧克力",Count = 2,Describe = "一包已打開的黑色巧克力，到期日被劃掉" },
        new Data(){ Name = "白色藥水",Count = 0,Describe = "不斷冒泡的不知名白色藥水，未封蓋" },
        new Data(){ Name = "紅色藥水",Count = 3,Describe = "不斷冒泡的不知名紅色藥水，未封蓋" },
        new Data(){ Name = "橙色藥水",Count = 7,Describe = "不斷冒泡的不知名橙色藥水，未封蓋" },
        new Data(){ Name = "黃色藥水",Count = 1,Describe = "不斷冒泡的不知名黃色藥水，未封蓋" },
        new Data(){ Name = "綠色藥水",Count = 4,Describe = "不斷冒泡的不知名綠色藥水，未封蓋" },
        new Data(){ Name = "藍色藥水",Count = 5,Describe = "不斷冒泡的不知名藍色藥水，未封蓋" },
        new Data(){ Name = "鑰匙",Count = 0,Describe = "疑似有防盜芯片的鑰匙" }
    };
    // Start is called before the first frame update
    void Start()
    {
        DrawData(datas);
        currentDataInt = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DW() {
        DrawData(datas);
    }

    void DrawData(Data[] data)
    {
        foreach (var item in data)
        {
            if (item.Count>0)
            {
                Debug.Log(item.Name+":"+item.Describe+"("+item.Count+")");
            }
        }
    }

    public void CurrentDataAdd(int arrayCount) {
        datas[arrayCount].Count++;
        Debug.Log(datas[arrayCount].Name+datas[arrayCount].Count);
    }

    public void CurrentDataDiv()
    {
        if (datas[currentDataInt].Count > 0)
        {
            datas[currentDataInt].Count--;
        }
        else {return;}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Object")
        {
            CurrentDataAdd(int.Parse(collision.transform.name));
            DW();
        }

    }
}



struct Data {
    public string Name { get; set; }
    public int Count { get; set; }
    public string Describe { get; set; }
}