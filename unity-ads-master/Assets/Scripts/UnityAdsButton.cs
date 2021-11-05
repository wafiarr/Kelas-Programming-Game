using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnityAdsButton : MonoBehaviour
{
    public Button btnAdd;
    public Button btnUse;
    public Text txCoin;

    int coin = 0;
    string placementId = "rewardedVideo";
    #if UNITY_IOS
    private string gameId = "4437860";
    #elif UNITY_ANDROID
    private string gameId = "4437861";
    #endif

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        if (btnAdd) btnAdd.onClick.AddListener(ShowAd);
        if (btnUse) btnUse.onClick.AddListener(UseCoin);

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(btnAdd) btnAdd.interactable = Advertisement.IsReady(placementId);
        btnUse.interactable = (coin > 0);
    }

    [System.Obsolete]
    void ShowAd()
    {
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;
        Advertisement.Show(placementId, options);
    }
    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            Debug.Log("Video Selesai - Tawarkan coin ke pemain");
            coin += 50;
            txCoin.text = "Coin: " + coin;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.LogWarning("Video dilewati - tidak menawarkan coin ke pemain");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.LogError("Video tidak ditampilkan");
        }
    }
    void UseCoin()
    {
        if (coin > 0)
        {
            coin -= 10;
            txCoin.text = "Coin: " + coin;
        }
    }
}