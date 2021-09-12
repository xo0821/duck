using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    static int currentDataInt;
    Data[] datas = new Data[9] {
        new Data(){ Name = "�ե��J�O",Count = 0,Describe = "�@�]�w���}���զ⥩�J�O�A�����Q����" },
        new Data(){ Name = "�¥��J�O",Count = 2,Describe = "�@�]�w���}���¦⥩�J�O�A�����Q����" },
        new Data(){ Name = "�զ��Ĥ�",Count = 0,Describe = "���_�_�w�������W�զ��Ĥ��A���ʻ\" },
        new Data(){ Name = "�����Ĥ�",Count = 3,Describe = "���_�_�w�������W�����Ĥ��A���ʻ\" },
        new Data(){ Name = "����Ĥ�",Count = 7,Describe = "���_�_�w�������W����Ĥ��A���ʻ\" },
        new Data(){ Name = "�����Ĥ�",Count = 1,Describe = "���_�_�w�������W�����Ĥ��A���ʻ\" },
        new Data(){ Name = "����Ĥ�",Count = 4,Describe = "���_�_�w�������W����Ĥ��A���ʻ\" },
        new Data(){ Name = "�Ŧ��Ĥ�",Count = 5,Describe = "���_�_�w�������W�Ŧ��Ĥ��A���ʻ\" },
        new Data(){ Name = "�_��",Count = 0,Describe = "�æ������s������_��" }
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