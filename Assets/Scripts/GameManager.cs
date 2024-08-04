using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scorePlayer1Text;
    [SerializeField] private TextMeshProUGUI scorePlayer2Text;
    [SerializeField] private GameObject ball;
    [SerializeField] private TextMeshProUGUI goalsText;
    [SerializeField] private GameObject message;
    private int goals;
    private int scorePlayer1;
    private int scorePlayer2;
    // Start is called before the first frame update
    void Start()
    {
        goalsText.text = "";
        scorePlayer1 = 0;
        scorePlayer2 = 0;
    }
    public void addScore(string name){
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
    public void playGame(){
        if(checkInput()) SceneManager.LoadScene(1);
        else message.SetActive(true);
    }
    private bool checkInput(){
        Debug.Log(goalsText.text + "i");
        string text = goalsText.text.Trim();
        Debug.Log(text + "ok");
        if(int.TryParse(text, out goals)){
            Debug.Log("ok");
            return true;
        }
        else return false;
    }
    public void hiddenMessage(){
        message.SetActive(false);
    }
}
