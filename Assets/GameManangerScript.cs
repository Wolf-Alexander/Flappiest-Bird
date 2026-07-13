using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManangerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject startScreen;
    public BirdScript bird;
    public PipeSpawnScript pipe;
    public GameObject text;
    public bool hasStarted = false;

    public GameObject birdy;
    void Start()
    {
        text.SetActive(false);
        birdy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        startScreen.SetActive(false);

        hasStarted = true;

        text.SetActive(true);

        birdy.SetActive(true);

        bird.myRigidbody.gravityScale = 2;

    }
}
