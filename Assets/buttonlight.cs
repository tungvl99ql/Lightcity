using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonlight : MonoBehaviour
{
    private bool on = true;
    
 
   public void onofflight()
    {
        if (on)
        {
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("light");
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(false);
            }
            GameObject.Find("Button").GetComponentInChildren<Text>().text = "OFF";
            on = false;
        }
        else
        {
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("light");
            foreach (GameObject go in gameObjectArray)
            {
                go.SetActive(true);
            }
            GameObject.Find("Button").GetComponentInChildren<Text>().text = "ON";
            on = true;
        }
    }
}
