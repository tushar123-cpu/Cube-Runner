using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalscoretext;

    int myScore = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();
        finalscoretext.text = "SCORE: " + myScore.ToString();

    }
    public void Addscore(int score)
    {
        myScore = myScore + score;
    }
}
