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
        GenerateButton(0);
    }
    public void GenerateButton2()
    {
        GenerateButton(1);
    }
    public void GenerateButton3()
    {
        GenerateButton(2);
    }
     public void GenerateButton4()
    {
        GenerateButton(3); 
    }
    void GenerateButton(int buttonId)
    {
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
    }
}
