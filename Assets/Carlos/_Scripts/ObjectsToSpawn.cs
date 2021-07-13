using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsToSpawn : MonoBehaviour
{
    public GameObject[] objetsToSpawn;
    public int currentId;
    public int buttonId;
    public Transform spawnPoint;
    public Button[] buttons;
    
    public void GenerateButton1()
    {
        buttonId = 0;
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
    }
    public void GenerateButton2()
    {
        buttonId = 1;
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
    }
    public void GenerateButton3()
    {
        buttonId = 2;
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
    }
     public void GenerateButton4()
    {
        buttonId = 3;
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
    }
}
