using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float smoothSpeed;

    void Start()
    {
        offset = transform.position - ball.position;
    }
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);   //Bu en yaygın olarak, iki uç nokta arasındaki bir çizgi boyunca yolun bir kısmını bulmak için kullanılır
        transform.position = newPos;
    }
}
