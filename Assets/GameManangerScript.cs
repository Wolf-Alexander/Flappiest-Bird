using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManangerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject startScreen;
    public BirdScript bird;
    public PipeSpawnScript pipe;
    public PipeScript pipy;
    public GameObject text;
    public bool hasStarted = false;
    public GameObject slider;
    public SliderScript sScript;
    public Text hstext;
    public int highscore;

    public GameObject birdy;
    void Start()
    {
        text.SetActive(false);
        birdy.SetActive(false);
        slider.SetActive(false);
        highscore = PlayerPrefs.GetInt("Highscore",0);

        hstext.text = "Highscore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        startScreen.SetActive(false);

        slider.SetActive(false);

        hasStarted = true;

        text.SetActive(true);

        birdy.SetActive(true);

        bird.myRigidbody.gravityScale = 2;

    }

    public void setDifficulty()
    {
        if (slider.activeInHierarchy)
        {
            slider.SetActive(false);
        }
        else
        {
            slider.SetActive(true);
        }
    }
}
