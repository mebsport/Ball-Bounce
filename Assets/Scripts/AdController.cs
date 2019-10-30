using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class AdController : MonoBehaviour
{
    private string store_id = "3342927";

    private string video_ad = "video";
    private string banner_ad = "GameBanner";

    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(store_id, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
