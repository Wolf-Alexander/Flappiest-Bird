using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highscore;
    public Text scoretext;
    public Text hstext;
    public GameObject gameOverScreen;
    public SliderScript slider;
    public Slider s;
    public GameObject music;
    public AudioSource scoresound;
    [ContextMenu("Increase Score")]

    void Awake()
    {
        highscore = PlayerPrefs.GetInt("Highscore",0);
    }
    public void addScore(int scoreToAdd)
    {
        scoresound.Play();
        playerScore += scoreToAdd;
        scoretext.text = playerScore.ToString();

        if (playerScore >= highscore)
        {
            hstext.text = "Highscore: " + playerScore.ToString();
            highscore = playerScore;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        PlayerPrefs.SetInt("Highscore",highscore);
        PlayerPrefs.SetFloat("Difficulty",s.value);
        //hstext.text = "Highscore: " + highscore;
        music.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
