using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public Animator anim;
    public static Sky instance;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Awake()
    {
        MakeInstance();
    }
    void Update()
    {
        
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
