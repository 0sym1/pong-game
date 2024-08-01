using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scorePlayer1Text;
    [SerializeField] private TextMeshProUGUI scorePlayer2Text;
    [SerializeField] private GameObject ball;
    private int scorePlayer1;
    private int scorePlayer2;
    // Start is called before the first frame update
    void Start()
    {
        scorePlayer1 = 0;
        scorePlayer2 = 0;
    }
    public void addScore(string name){
        Debug.Log("ok");
        if(name == "Goal1") scorePlayer2++;
        else scorePlayer1++;

        updateScore();
    }
    private void updateScore(){
        scorePlayer1Text.text = scorePlayer1.ToString();
        scorePlayer2Text.text = scorePlayer2.ToString();
    }

    public void pauseGame(){
        Time.timeScale = 0; 
    }
    public void resumeGame(){
        Time.timeScale = 1;
    }
}
