using GoogleMobileAds;
using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class reklam : MonoBehaviour
{
#if UNITY_ANDROID
    private string _adunitId = "ca-app-pub-5321213106379620/1955887912";
#else
    private string _adunitId = "unused";
#endif

    internal int rek = 0;

    private InterstitialAd _interstitialAd;
    private string testAdUnitId = "ca-app-pub-3940256099942544/1033173712";
    public Button showAdButton;

    public void Start()
    {
        
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {

        });


        if (showAdButton != null)
        {
            showAdButton.onClick.AddListener(OnShowAdButtonClicked);
        }

        loadInterstitiad();
        ShowInterstitialAd();
    }
    public void loadInterstitiad()
    {
        if (_interstitialAd != null)
        {
            _interstitialAd.Destroy();
            _interstitialAd = null;
        }

        UnityEngine.Debug.Log("reklam yükleniyor kardeþim");

        var adRequest = new AdRequest();
        string adUnitToLoad = _adunitId;

        InterstitialAd.Load(adUnitToLoad, adRequest,
        (InterstitialAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                UnityEngine.Debug.LogError("nanaeyi yedin");
                return;
            }

            UnityEngine.Debug.Log("reklam yüklendi");
            _interstitialAd = ad;
        });
    }

    public void ShowInterstitialAd()
    {
        if (_interstitialAd != null && _interstitialAd.CanShowAd())
        {
            UnityEngine.Debug.Log("reklam gösteriliyoru");
            _interstitialAd.Show();
        }
        else
        {
            UnityEngine.Debug.Log("reklam hazýr deðil");
        }

    }

    void OnShowAdButtonClicked()
    {
        
    }






}
