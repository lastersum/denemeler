using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
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
    }
    public void loadInterstitiad()
    {
        if (_interstitialAd != null)
        {
            _interstitialAd.Destroy();
            _interstitialAd = null;
        }

        Debug.Log("reklam yükleniyor kardeþim");

        var adRequest = new AdRequest();
        string adUnitToLoad = _adunitId;

        InterstitialAd.Load(adUnitToLoad, adRequest,
        (InterstitialAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                Debug.LogError("nanaeyi yedin");
                return;
            }

            Debug.Log("reklam yüklendi");
            _interstitialAd = ad;
        });
    }

    public void ShowInterstitialAd()
    {
        if (_interstitialAd != null && _interstitialAd.CanShowAd())
        {
            Debug.Log("reklam gösteriliyoru");
            _interstitialAd.Show();
        }
        else
        {
            Debug.Log("reklam hazýr deðil");
        }

    }

    void OnShowAdButtonClicked()
    {
        if (rek == 0)
        {
            Debug.Log("reklam gösteriliyor");
            ShowInterstitialAd();
            rek++;
        }
        if (rek == 1)
        {

        }
        
    }






}
