using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamOlusturmaca : MonoBehaviour
{
    public GameObject dusman;
    public float min = 1f;
    public float max = 5f;
    public Transform spawnNoktasi;
    void Start()
    {
        StartCoroutine(MerhabaDongusu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MerhabaDongusu()
    {
        while (true) // S�rekli tekrarla
        {
            // enAzBekleme ile enCokBekleme aras�nda rastgele bir s�re se�
            float rastgeleSure = Random.Range(min, max);

            // Se�ilen s�re kadar bekle
            yield return new WaitForSeconds(rastgeleSure);

            // Bekleme bitti�inde konsola "Merhaba!" yaz
             SpawnObje();
        }
    }
    void SpawnObje()
    {
        // Instantiate fonksiyonu, bir Prefab'den yeni bir GameObject kopyas� olu�turur.
        // �lk parametre: Olu�turulacak Prefab
        // �kinci parametre: Olu�turulaca�� pozisyon
        // ���nc� parametre: Olu�turulaca�� rotasyon (d�n��)
        Instantiate(dusman  , spawnNoktasi.position, spawnNoktasi.rotation);

        Debug.Log("Bir obje spawnland�!");
    }
}
