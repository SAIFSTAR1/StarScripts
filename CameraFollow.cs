using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    private Vector3 pos;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }


    void LateUpdate()
    {
        pos = transform.position;
        pos.x = player.position.x;
        pos.y = player.position.y;

        transform.position = pos;
    }
}
