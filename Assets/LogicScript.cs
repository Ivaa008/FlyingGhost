using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    //we want to set a number for the players score
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen; //a rreference to the game over screen
    public AudioSource scoreSound;

    //adding a function 
    //adding this so i can test the code in Unity
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        //add 1 to the player's score
        //playerScore++;
        playerScore += scoreToAdd;
        //change the text to be this number
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void quitGame()
    {
        SceneManager.LoadScene("MainTitleScene");
    }
}
