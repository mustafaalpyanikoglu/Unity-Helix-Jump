using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    [SerializeField]
    private GameObject splash;
    void Start()
    {
        Destroy(splash, 2);
    }
    void Update()
    {
        
    }
}
