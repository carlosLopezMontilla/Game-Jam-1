using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject buttons;

    public TextMeshProUGUI creditText;
    public GameObject credit;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
        print("Juego cerrado");
    }
    public void Credits()
    {
        credit.SetActive(true);
        buttons.SetActive(false);
        creditText.text = "Bubbletea de Xerographer Fonts - Timer \n Gamerock de Din Studio - Botones \n"; 
    }

    public void Continue()
    {
        credit.SetActive(false);
        buttons.SetActive(true);
    }
}
