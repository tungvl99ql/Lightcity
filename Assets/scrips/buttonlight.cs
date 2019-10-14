using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonlight : MonoBehaviour
{
    private bool on = true;
    GameObject[] gameObjectArray;
        private void Start()
    {
        gameObjectArray = GameObject.FindGameObjectsWithTag("light");
    }

    public void onofflight()
    {
        if (on)
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }
            GameObject.Find("LightButton").GetComponentInChildren<Text>().text = "LIGHT OFF";
            on = false;
        }
        else
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(true);
            }
            GameObject.Find("LightButton").GetComponentInChildren<Text>().text = "LIGHT ON";
            on = true;
        }
    }
}
