using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter : MonoBehaviour
{
    public BolumDondurme b;
    public Coin parascript;
    Rigidbody rb;
    public float speed = 10f; 
    float vertical;           
    float horizontal;         
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Girdileri al
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        float currentYVelocity = rb.velocity.y;

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed;

        rb.velocity = new Vector3(movement.x, currentYVelocity, movement.z);

    }
    void OnCollisionEnter(Collision carpisanObje)
    {
        int bolumseviye = 2;
        if (carpisanObje.gameObject.CompareTag("dusman"))
        {
            b.level = bolumseviye;
            SceneManager.LoadScene(3, LoadSceneMode.Additive);
        }
        if (carpisanObje.gameObject.CompareTag("coin"))
        {
            parascript.coin++;
            Destroy(carpisanObje.gameObject);
        }
    }
}
