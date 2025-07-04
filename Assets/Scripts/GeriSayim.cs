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
            Debug.LogError("GeriSayimMetni Inspector'da atanmadý! Lütfen Text (TMP) nesnenizi 'Geri Sayým Metni' alanýna sürükleyin.");
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
                geriSayimSuresi -= Time.deltaTime; // Gerçek zamana göre süreyi azalt
                GeriSayimGostergesiniGuncelle(geriSayimSuresi);
            }
            else
            {
                geriSayimSuresi = 0; // Negatif olmamasýný saðla
                sayacCalisiyor = false;
                GeriSayimGostergesiniGuncelle(geriSayimSuresi);
                SceneManager.LoadScene(3, LoadSceneMode.Single);
                Debug.Log("Geri Sayým Bitti!");
                // Geri sayým bittiðinde daha fazla eylem ekleyebilirsiniz,
                // yeni bir sahne yüklemek, oyun bitti ekraný göstermek vb.
            }
        }
    }
    public void GeriSayimiBaslat()
    {
        geriSayimSuresi = 60f; // Yeniden baþlatmak isterseniz 30'a sýfýrla
        sayacCalisiyor = true;
        GeriSayimGostergesiniGuncelle(geriSayimSuresi); // Ýlk gösterim
    }

    void GeriSayimGostergesiniGuncelle(float gosterilecekSure)
    {
        // Görüntüleme amacýyla sürenin sýfýrýn altýna düþmemesini saðla
        if (gosterilecekSure < 0)
        {
            gosterilecekSure = 0;
        }

        // Dakika ve saniyeleri hesapla
        float dakikalar = Mathf.FloorToInt(gosterilecekSure / 60);
        float saniyeler = Mathf.FloorToInt(gosterilecekSure % 60);

        // Süreyi SS olarak biçimlendir (örneðin "05")
        geriSayimMetni.text = string.Format("{0:00}", saniyeler);

        // Eðer MM:SS formatý isterseniz (kýsa süreler için bile):
        // geriSayimMetni.text = string.Format("{0:00}:{1:00}", dakikalar, saniyeler);
    }
}
