using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    int score = 0;

    public AdController adController;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp()
    {
        score++;
        if(score >=4)
        {
            Win();
        }
    }
    void Win()
    {
        adController.ShowBannerAd();
        winPanel.SetActive(true);
    }
    public void Restart()
    {
        adController.ShowVideoAd();
        SceneManager.LoadScene("Game");
    }
}
