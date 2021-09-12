using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObj : MonoBehaviour
{
    public void AvtiveIt(GameObject gameObject) {
        gameObject.active = true;
    }

    public void UnAvtiveIt(GameObject gameObject)
    {
        gameObject.active = false;
    }
}
