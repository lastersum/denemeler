using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public Text skorText;
    public Coin parascript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GuncelSkoruGoster();
    }
    void GuncelSkoruGoster()
    {
        if (skorText != null)
        {
            skorText.text = "Skor:" + parascript.coin.ToString(); // Yeni yazýyý atama
        }
        else
        {
            Debug.LogError("Skor Text bileþeni atanmadý! Inspector'dan atadýðýnýzdan emin olun.");
        }
    }
}
