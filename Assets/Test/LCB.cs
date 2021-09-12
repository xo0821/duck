using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class LCB : MonoBehaviour,IPointerDownHandler
{
    private bool pointerDown;
    private float pointerDownTimer;

    [SerializeField]
    public float requiedHoldTime;
    public UnityEvent onLongClick;

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (pointerDown)
        {
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer>=requiedHoldTime)
            {
                if (onLongClick !=null)
                {
                    onLongClick.Invoke();
                }
            }
        }
    }
}
