using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btn : MonoBehaviour
{
    public int level=2;
    public Button showButton;
    void Start()
    {
        showButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButtonClick()
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
}
