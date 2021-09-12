using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveRestartUi : MonoBehaviour
{
    public ItemList itemList;
    int[] ItemlistInit = new int[] { 0,2,0,3,7,1,4,5,0};

    public GameObject gameObject;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            gameObject.active = true;
            PlayerCtrl.CanMove = false;
        }
    }


    public void Cancel() {
        gameObject.active = false;
        PlayerCtrl.CanMove = true;
    }

    public void RestartGame()
    {
        for (int i = 0; i < 9; i++)
        {
            itemList.itemList[i].itemNum = ItemlistInit[i];
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
