using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public ParticleSystem pr;
    public static Rain instance;
    private void Awake()
    {
        MakeInstance();
    }
    void Start()
    {
        pr = GetComponent<ParticleSystem>();
        pr.Stop();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}
