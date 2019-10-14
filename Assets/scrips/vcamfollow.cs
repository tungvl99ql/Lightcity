using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class vcamfollow : MonoBehaviour
{

    private GameObject player;
    private CinemachineVirtualCamera vcam;
    private Cinemachine.CinemachineConfiner confiner; 
    private void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        player = GameObject.FindGameObjectWithTag("Player");
        vcam.Follow = player.transform;
    }
    private void Update()
    {
       
    }
}
