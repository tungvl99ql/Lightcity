using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohouse : MonoBehaviour
{
    public int sceneID;
    public GameObject arrow;
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            arrow.SetActive(true);
            if (Input.GetKey(KeyCode.S))
            {
                Application.LoadLevel(sceneID);
                playerscrips.instance.sceneswap = false;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            arrow.SetActive(false);
            
        }
    }
}
