using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int Score = 0;
    private int SmallStar = 5;
    private int LargeStar = 30;
    private int Cloud = 10;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score:" + Score;
    }


    // Update is called once per frame
    void Update()
    {

    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "SmallStarTag")
        {
            Score += SmallStar;
        }
        else if (col.gameObject.tag == "LargeStarTag")
        {
            Score += LargeStar;
        }
        else if (col.gameObject.tag == "SmallCloudTag" || col.gameObject.tag == "LargeCloudTag")
        {
            Score += Cloud;
        }
        this.scoreText.GetComponent<Text>().text = "Score:" + Score;
    }
}


