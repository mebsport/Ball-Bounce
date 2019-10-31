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

    private float randomNumber;
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
        randomNumber = UnityEngine.Random.Range(0f, 9f);
        Debug.Log(randomNumber);
        if(randomNumber <= 3)
        {
            adController.ShowVideoAd();
            SceneManager.LoadScene("Game");
        }
        else
        {
            SceneManager.LoadScene("Game");
        }
    }
}
