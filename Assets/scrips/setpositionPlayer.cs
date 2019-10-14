using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setpositionPlayer : MonoBehaviour
{

    public Vector3 spawnerPosition;
   
    private void Start()
    {
        spawnerPosition = this.transform.position;
        int index = SceneManager.GetActiveScene().buildIndex;
        if (playerscrips.instance.sceneswap == false)
        {
            GameObject.Find("Player").transform.position = spawnerPosition;
        }
    }
}
