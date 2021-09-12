using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveRestartUi : MonoBehaviour
{
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
