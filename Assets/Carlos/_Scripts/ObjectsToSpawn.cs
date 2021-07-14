using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsToSpawn : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject[] objetsToSpawn;
    public int currentId;
    public int buttonId;
    public int objectId;
    public Transform spawnPoint;
    public Button[] buttons;
    

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void GenerateButton1()
    {
        GenerateButton(0);
        objectId = 0;
    }
    public void GenerateButton2()
    {
        GenerateButton(1);
        objectId = 1;
    }
    public void GenerateButton3()
    {
        GenerateButton(2);
        objectId = 2;
    }
     public void GenerateButton4()
    {
        GenerateButton(3); 
        objectId = 3;
    }
    void GenerateButton(int buttonId)
    {
        currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject objectSpawned = Instantiate(objetsToSpawn[currentId], spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;
        gameManager.currentObject = objectSpawned;
    }
}
