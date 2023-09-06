using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public class Player : MonoBehaviour
{
    private float speed = 8f;
    private Vector3 mousePos;
    private float moveX, moveY;
    private Transform dim;
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        mousePos = Input.mousePosition;
        dim = transform;

        float xDiff = dim.position.x - mousePos.x;
        float yDiff = dim.position.y - mousePos.y;

        float tanTheta = yDiff / xDiff;

        float theta = Convert.ToSingle(Math.Atan(tanTheta));

        Quaternion target = Quaternion.Euler(0, 0, -theta*500);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 10f);

        transform.position += new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
    }
}
