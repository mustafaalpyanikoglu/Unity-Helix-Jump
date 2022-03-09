using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //rb.velocity = new Vector3(0, 5, 0) ;
        rb.AddForce(Vector3.up * jumpForce); //topun yukarı zıplaması
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.22f,0f), transform.rotation);  //topun iz bırakması
        splash.transform.SetParent(collision.gameObject.transform);
        //17. satırda problem var
        string metarialName = collision.gameObject.GetComponent<MeshRenderer>().material.name; // çarptığı metarial adını öğreniyoruz

        Debug.Log("Metaryal Adı: " + metarialName);
        if(metarialName.Contains("Unsafe"))
        {
            //Bölüm Yeniden Başlayacak
            gm.restartGame();
        }
        else if (metarialName.Contains("Last"))
        {
            //Bir sonraki levele geçecek
            Debug.Log("Lwl up");
        }
        else if (metarialName.Contains("Safe"))
        {
            //Bir sonraki levele geçecek
            Debug.Log("Farklı");
        }

    }

}
