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
        while (true) // Sürekli tekrarla
        {
            // enAzBekleme ile enCokBekleme arasýnda rastgele bir süre seç
            float rastgeleSure = Random.Range(min, max);

            // Seçilen süre kadar bekle
            yield return new WaitForSeconds(rastgeleSure);

            // Bekleme bittiðinde konsola "Merhaba!" yaz
             SpawnObje();
        }
    }
    void SpawnObje()
    {
        // Instantiate fonksiyonu, bir Prefab'den yeni bir GameObject kopyasý oluþturur.
        // Ýlk parametre: Oluþturulacak Prefab
        // Ýkinci parametre: Oluþturulacaðý pozisyon
        // Üçüncü parametre: Oluþturulacaðý rotasyon (dönüþ)
        Instantiate(dusman  , spawnNoktasi.position, spawnNoktasi.rotation);

        Debug.Log("Bir obje spawnlandý!");
    }
}
