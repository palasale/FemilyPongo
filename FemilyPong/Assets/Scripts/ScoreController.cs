using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    public int score = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
        return score;
    }

    public int RemovePoint()
    {
        score--;
        scoreText.text = score.ToString();
        return score;
    }
}
