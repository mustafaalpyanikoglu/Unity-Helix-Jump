using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    public int ringCount;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(transform.position.y >= ball.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
