using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;


    void Start()
    {
        
    }
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))//basılı olduğu sürece hareket etsin
        {
            transform.Rotate(0f, -1*moveX * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
