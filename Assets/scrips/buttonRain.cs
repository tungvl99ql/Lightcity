using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonRain : MonoBehaviour
{
    private bool on = true;
   
    public void RainOn()
    {
        if (on)
        {
            Rain.instance.pr.Play();
            Sky.instance.anim.SetBool("Rain", true);

            on = false;
        }
        else
        {
            Rain.instance.pr.Stop();
            Sky.instance.anim.SetBool("Rain", false);
            on = true;
        }
    }
}
