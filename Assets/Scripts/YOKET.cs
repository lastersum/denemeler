using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOKET : MonoBehaviour
{
    void OnCollisionEnter(Collision carpisanObje)
    {

        if (carpisanObje.gameObject.CompareTag("dusman"))
        {
            Debug.Log("D��mana �arpt�k!");
            Destroy(carpisanObje.gameObject); // �arpt���m�z objeyi yok et
        }
        if (carpisanObje.gameObject.CompareTag("coin"))
        {
            Debug.Log("Alt�n� ka��rd�k baba");
            Destroy(carpisanObje.gameObject); // �arpt���m�z objeyi yok et
        }
    }
}
