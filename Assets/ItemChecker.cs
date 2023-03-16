using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChecker : MonoBehaviour
{
    //variable for score counting
    public int score;
    //variable for reference to Score GameObject
    public GameObject ScoreObject;
    //variable for reference to Text component on Score GameObject
    Text scoreText;
    //variable for reference to GameOver GameObject
    public GameObject GameOverObject;
    //variable for reference to Text component on GameOver GameObject
    Text gameOverText;

    //will be executed once
    void Start()
    {
        //reference scoreText to Text component
        scoreText = ScoreObject.GetComponent<Text>();
        //reference gameOverText to Text component
        gameOverText = GameOverObject.GetComponent<Text>();
        //hide the game over text initially
        GameOverObject.SetActive(false);
    }

    //will be executed if one Collider2D went into Trigger2D
    void OnTriggerEnter2D(Collider2D other)
    {

        //check if collided gameobject has tag Good
        if (other.gameObject.tag == "Good")
        {
            //increase score
            score = score + 10;
            //set string text to score value, which was converted from int to string
            scoreText.text = score.ToString();
            //delete collided gameobject from the scene
            Destroy(other.gameObject);

        }
        //check if collided gameobject has tag Bad
        if (other.gameObject.tag == "Bad")
        {
            //end game
            GameOver();
            //delete collided gameobject from the scene
            Destroy(other.gameObject);
        }
    }

    void GameOver()
    {
        //display game over text
        gameOverText.text = "Game Over!";
        GameOverObject.SetActive(true);
    }
}
