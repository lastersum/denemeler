using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdamOlusturmaca : MonoBehaviour
{
    
    public Coin parascript;
    public GameObject dusman , altin;
    public float min = 0.5f;
    public float max = 1.5f;
    public Transform spawnNoktasi1, spawnNoktasi2, spawnNoktasi3, spawnNoktasi4, spawnNoktasi5, rotate;
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
            float efendimabi = Random.Range(0, 5);

            // Seçilen süre kadar bekle
            yield return new WaitForSeconds(rastgeleSure);

            if (efendimabi == 1) { SpawnCoin(); }
            else { SpawnObje(); }
            

        }
    }
    void SpawnObje()
    {
        int r = Random.Range(0, 5);
        if (r==0){
            Instantiate(dusman, spawnNoktasi1.position, spawnNoktasi1.rotation);

            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 1)
        {
            Instantiate(dusman, spawnNoktasi2.position, spawnNoktasi2.rotation);

            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 2)
        {
            Instantiate(dusman, spawnNoktasi3.position, spawnNoktasi3.rotation);

            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 3)
        {
            Instantiate(dusman, spawnNoktasi4.position, spawnNoktasi4.rotation);

            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 4)
        {
            Instantiate(dusman, spawnNoktasi5.position, spawnNoktasi5.rotation);

            Debug.Log("Bir obje spawnlandý!");
        }

    }
    void SpawnCoin()
    {
        int r = Random.Range(0, 5);
        if (r == 0)
        {
            Vector3 a = new Vector3(0, -90, 0);
            Vector3 s = new Vector3(spawnNoktasi1.position.x + 0.01f, spawnNoktasi1.position.y + 0.05f, spawnNoktasi1.position.z + 0.02f);
            Instantiate(altin, s, rotate.rotation);
            parascript.amount++;
            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 1)
        {
            Vector3 a = new Vector3(0, -90, 0);
            Vector3 s = new Vector3(spawnNoktasi2.position.x + 0.01f, spawnNoktasi2.position.y + 0.05f, spawnNoktasi2.position.z + 0.02f);
            Instantiate(altin, s, rotate.rotation);
            parascript.amount++;
            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 2)
        {
            Vector3 a = new Vector3(0, -90, 0);
            Vector3 s = new Vector3(spawnNoktasi3.position.x + 0.01f, spawnNoktasi3.position.y + 0.05f, spawnNoktasi3.position.z + 0.02f);
            Instantiate(altin, s, rotate.rotation);
            parascript.amount++;
            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 3)
        {
            Vector3 a = new Vector3(0, -90, 0);
            Vector3 s = new Vector3(spawnNoktasi4.position.x + 0.01f, spawnNoktasi4.position.y + 0.05f, spawnNoktasi4.position.z + 0.02f);
            Instantiate(altin, s, rotate.rotation);
            parascript.amount++;
            Debug.Log("Bir obje spawnlandý!");
        }
        if (r == 4)
        {
            Vector3 a = new Vector3(0, -90, 0);
            Vector3 s = new Vector3(spawnNoktasi5.position.x + 0.01f, spawnNoktasi5.position.y + 0.05f, spawnNoktasi5.position.z + 0.02f);
            Instantiate(altin, s, rotate.rotation);
            parascript.amount++;
            Debug.Log("Bir obje spawnlandý!");
        }
        
    }
}
