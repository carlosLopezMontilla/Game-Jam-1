using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Stop time and activate the timer")]
    public float totalTime = 10f;
    public float timeToEnd;
    public TextMeshProUGUI timeText;
    public GameObject timer;
    public PlayerController pControl;
    public Jump jump;
    public bool buttonPressed;
    public bool powerUsed;

    [Header("Object to spawn")]
    public GameObject downMenu;
    public ObjectsToSpawn objectsToSpawn;
    public GameObject currentObject;

    public int currentscene;

    private void Start()
    {
        downMenu.SetActive(false);
        timer.SetActive(false);
        buttonPressed = false;
        timeToEnd = totalTime;
        powerUsed = false;
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.O))
        {
            buttonPressed = true;
        }
        if (buttonPressed && !powerUsed)
        {
            Place();
        }
    }

    void Place()
    {
        timer.SetActive(true);
        downMenu.SetActive(true);
        timeToEnd -= Time.deltaTime;
        timeText.text = timeToEnd.ToString("F0");
        pControl.GetComponent<PlayerController>().enabled = false;
        pControl.GetComponent<Jump>().enabled = false;
        if (timeToEnd <= 0)
        {
            timeToEnd = 10;
            buttonPressed = false;
            pControl.GetComponent<PlayerController>().enabled = true;
            pControl.GetComponent<Jump>().enabled = true;
            timer.SetActive(false);
            downMenu.SetActive(false);
            currentObject.GetComponent<BlockController>().enabled = false;
            powerUsed = true;

        }

    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
        SceneManager.LoadScene(0);

    }

}



