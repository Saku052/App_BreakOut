using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.Events;

public class AdMobInterstitial : MonoBehaviour
{
    public UnityEvent OnOpeningAd;
    public UnityEvent OnClosedAd;
    private InterstitialAd interstitial;

    private void Start() {
        {
            RequestInterstitial();
        }
    }

public void RequestInterstitial()
{
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
    #elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
    #else
        string adUnitId = "unexpected_platform";
    #endif

    // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);

    // Called when an ad request has successfully loaded.
    this.interstitial.OnAdLoaded += HandleOnAdLoaded;
    // Called when an ad is shown.
    this.interstitial.OnAdOpening += HandleOnAdOpened;
    // Called when the ad is closed.
    this.interstitial.OnAdClosed += HandleOnAdClosed;
    

    DestoryInterstitialAd();

    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    this.interstitial.LoadAd(request);
}

public void HandleOnAdLoaded(object sender, EventArgs args)
{
    MonoBehaviour.print("HandleAdLoaded event received");
}



public void HandleOnAdOpened(object sender, EventArgs args)
{
    MonoBehaviour.print("HandleAdOpened event received");
    OnOpeningAd.Invoke();
}

public void HandleOnAdClosed(object sender, EventArgs args)
{
    MonoBehaviour.print("HandleAdClosed event received");
    OnClosedAd.Invoke();
}


public void ShowInterstitialAdd()
{
  if (this.interstitial.IsLoaded()) {
    this.interstitial.Show();
  }
  else{
      Debug.Log("読み込み出来てない");
  }
}

public void DestoryInterstitialAd()
{
    interstitial.Destroy();
}
   

}
