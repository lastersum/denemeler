using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOKET : MonoBehaviour
{
    void OnCollisionEnter(Collision carpisanObje)
    {

        if (carpisanObje.gameObject.CompareTag("dusman"))
        {
            Debug.Log("Düþmana çarptýk!");
            Destroy(carpisanObje.gameObject); // Çarptýðýmýz objeyi yok et
        }
        if (carpisanObje.gameObject.CompareTag("coin"))
        {
            Debug.Log("Altýný kaçýrdýk baba");
            Destroy(carpisanObje.gameObject); // Çarptýðýmýz objeyi yok et
        }
    }
}
