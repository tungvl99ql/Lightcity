using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class playerscrips : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX;
    public float movespeed = 5f;
    public Animator animator;
    public static playerscrips instance;
    public static bool playerExits;
    public CinemachineVirtualCamera vcam;
    public bool sceneswap = true; // check chuyen scene 
    private void Awake()
    {
        makeinstance();
        if (!playerExits)
        {
            playerExits = true;
            DontDestroyOnLoad(this);
        }
        if (FindObjectsOfType(GetType()).Length > 1)
            {
                Destroy(gameObject);
        }
       
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
        
    }
    void Update()
    {
        Move();
    }
    public void Move()
    {
        moveX = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + moveX, transform.position.y);
        animator.SetFloat("speed", Mathf.Abs(moveX));
        if(moveX < 0)
        {
            animator.SetFloat("duration", -1);
        }
        if(moveX > 0)
        {
            animator.SetFloat("duration", 1);
        }
    }
    public void makeinstance()
    {
        if(instance == null )
        {
            instance = this;
        }
    }
}
