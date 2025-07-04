using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GeriSayim : MonoBehaviour
{
    public float geriSayimSuresi = 60f;
    private bool sayacCalisiyor = false;
    public TextMeshProUGUI geriSayimMetni;
    void Start()
    {
        if (geriSayimMetni == null)
        {
            Debug.LogError("GeriSayimMetni Inspector'da atanmad�! L�tfen Text (TMP) nesnenizi 'Geri Say�m Metni' alan�na s�r�kleyin.");
            return;
        }

        GeriSayimiBaslat();
    }

    // Update is called once per frame
    void Update()
    {
        if (sayacCalisiyor)
        {
            if (geriSayimSuresi > 0)
            {
                geriSayimSuresi -= Time.deltaTime; // Ger�ek zamana g�re s�reyi azalt
                GeriSayimGostergesiniGuncelle(geriSayimSuresi);
            }
            else
            {
                geriSayimSuresi = 0; // Negatif olmamas�n� sa�la
                sayacCalisiyor = false;
                GeriSayimGostergesiniGuncelle(geriSayimSuresi);
                SceneManager.LoadScene(3, LoadSceneMode.Single);
                Debug.Log("Geri Say�m Bitti!");
                // Geri say�m bitti�inde daha fazla eylem ekleyebilirsiniz,
                // yeni bir sahne y�klemek, oyun bitti ekran� g�stermek vb.
            }
        }
    }
    public void GeriSayimiBaslat()
    {
        geriSayimSuresi = 60f; // Yeniden ba�latmak isterseniz 30'a s�f�rla
        sayacCalisiyor = true;
        GeriSayimGostergesiniGuncelle(geriSayimSuresi); // �lk g�sterim
    }

    void GeriSayimGostergesiniGuncelle(float gosterilecekSure)
    {
        // G�r�nt�leme amac�yla s�renin s�f�r�n alt�na d��memesini sa�la
        if (gosterilecekSure < 0)
        {
            gosterilecekSure = 0;
        }

        // Dakika ve saniyeleri hesapla
        float dakikalar = Mathf.FloorToInt(gosterilecekSure / 60);
        float saniyeler = Mathf.FloorToInt(gosterilecekSure % 60);

        // S�reyi SS olarak bi�imlendir (�rne�in "05")
        geriSayimMetni.text = string.Format("{0:00}", saniyeler);

        // E�er MM:SS format� isterseniz (k�sa s�reler i�in bile):
        // geriSayimMetni.text = string.Format("{0:00}:{1:00}", dakikalar, saniyeler);
    }
}
