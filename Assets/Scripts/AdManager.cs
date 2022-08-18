using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class AdManager : MonoBehaviour
{
    public const string RewardedUnitId = "ca-app-pub-3940256099942544/5224354917";

    private static RewardedAd rewardedAd;

    private void OnEnable() {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
    }

    public static void ShowAd (Action action) {
        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
        
        rewardedAd.OnUserEarnedReward += delegate { action.Invoke(); }; 
    }
}
