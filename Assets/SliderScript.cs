using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Slider slider;
    public float currentDifficulty;
    public PipeScript pipe;
    public PipeSpawnScript pipespawn;

    void Awake()
    {
        slider = GetComponent<Slider>();

        currentDifficulty = PlayerPrefs.GetFloat("Difficulty", 2);

        slider.value = currentDifficulty;

        applyDifficulty(currentDifficulty);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeDifficulty()
    {
        currentDifficulty = slider.value;
        applyDifficulty(currentDifficulty);
    }

    public void applyDifficulty(float currentDifficulty)
    {
        Debug.Log(currentDifficulty);

        if (currentDifficulty == 0)
        {
            pipe.moveSpeed = 5;
            pipespawn.spawnRate = 3;
        }
        else if (currentDifficulty == 1)
        {
            pipe.moveSpeed = 8;
            pipespawn.spawnRate = 2;
        }
        else if (currentDifficulty == 2)
        {
            pipe.moveSpeed = 12;
            pipespawn.spawnRate = 2;
        }
    }
}
