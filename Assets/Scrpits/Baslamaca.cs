using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Baslamaca : MonoBehaviour
{
    public Button m_YourFirstButton;
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButtonClick()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
