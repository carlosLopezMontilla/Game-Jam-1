using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float totalTime = 10f;
    public float timeToEnd;
    public TextMeshProUGUI timeText;


    private void Start()
    {
        timeToEnd = totalTime;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Time.timeScale = 0;
            timeToEnd -= 0.1f;
            timeText.text = timeToEnd.ToString("F3");
        }

       
    }
}



