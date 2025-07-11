using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter : MonoBehaviour
{
    public AudioSource voice;
    public AudioClip yurume,toplama;
    public Coin parascript;
    Rigidbody rb;
    public float speed = 10f; 
    float vertical;           
    float horizontal;         
    void Start()
    {
        voice = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        voice.clip = yurume;
        voice.Play();
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
        if (carpisanObje.gameObject.CompareTag("dusman"))
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        if (carpisanObje.gameObject.CompareTag("coin"))
        {
            parascript.coin++;
            Destroy(carpisanObje.gameObject);
            SesimiBirKez�al();
           
        }
    }
    public void SesimiBirKez�al()
    {
        if (voice != null && toplama != null)
        {
            voice.PlayOneShot(toplama);
            // Veya atanan klibi a��k�a oynat�p di�erlerini durdurmak isterseniz:
            // sesKayna��.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource veya AudioClip eksik!");
        }
    }
    void Awake()
    {
        // Bu GameObject �zerindeki AudioSource bile�enini al
        voice = GetComponent<AudioSource>();
        if (voice == null)
        {
            // E�er yoksa, yeni bir AudioSource ekle
            voice = gameObject.AddComponent<AudioSource>();
        }
        // E�er ses klibi Inspector'dan atanm��sa ve AudioSource'un klibi atanmam��sa ata
        if (toplama != null && voice.clip == null)
        {
            voice.clip = toplama;
        }
    }
}
