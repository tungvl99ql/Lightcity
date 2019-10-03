using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonlight : MonoBehaviour
{
    private bool on = true;
    GameObject[] gameObjectArray;
    private GameObject button;

    public void Start()
    {
        gameObjectArray = GameObject.FindGameObjectsWithTag("light");
        button = GameObject.Find("Button");
    }

    public void onofflight()
    {
        if (on)
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }
            button.GetComponentInChildren<Text>().text = "OFF";
            on = false;
        }
        else
        {
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(true);
            }
            button.GetComponentInChildren<Text>().text = "ON";
            on = true;
        }
    }
}
