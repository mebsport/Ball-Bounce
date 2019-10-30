using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    int score = 0;

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
        if(score >=5)
        {
            Win();
        }
    }
    void Win()
    {
        winPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
