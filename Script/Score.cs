using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public int score;
    public int highscore;
    public TextMeshProUGUI scoretext, highscoretext;
    
    void Start(){
        highscore = PlayerPrefs.GetInt("Score");
        highscoretext.text = "High Score: " + highscore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        score = Mathf.RoundToInt(player.transform.position.x - transform.position.x);
        scoretext.text = "Score: " + score.ToString();
    }
    public void End(){
        if(score > highscore){
            highscore = score;
            highscoretext.text = "High Score: " + highscore.ToString();
            PlayerPrefs.SetInt("Score", highscore);
            PlayerPrefs.Save();
        }
    }
}
