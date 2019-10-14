using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontrol : MonoBehaviour
{
    public static lightcontrol instance;
    private void Awake()
    {
        MakeInstance();
    }
  
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}
