using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public kus player;
    public Text scoreText;
    public GameObject PlayButton;
    public GameObject gameOver;
    private int score;


    private void Awake()
    {    Application.targetFrameRate = 60;
        Pause();
       
        
    }


    public void Play(){
        score = 0;
        scoreText.text = score.ToString();

        PlayButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Borular[] borular = FindObjectsOfType<Borular>();
        for (int i = 0; i < borular.Length; i++ ) {
            Destroy(borular[i].gameObject);
        }



    }

    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver(){
        gameOver.SetActive(true);
        PlayButton.SetActive(true);
        Pause();
        Debug.Log("Game Over");
    }

    public void IncreaseScore( ){

        score++;
        scoreText.text = score.ToString();
    }
}
