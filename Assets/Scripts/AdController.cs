using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdController : MonoBehaviour
{
    private string store_id = "3342927";

    private string video_ad = "video";
    private string banner_ad = "GameBanner";

    void Start()
    {
        Monetization.Initialize(store_id, false);
    }
    void Update()
    {

    }
    public void ShowVideoAd()
    {
        if (Monetization.IsReady(video_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
            }
        }
    }
    public void ShowBannerAd()
    {
        if (Monetization.IsReady(banner_ad))
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(banner_ad) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
            }
        }
    }
}
