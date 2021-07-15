using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsToSpawn : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject[] objetsToSpawn;
    public Sprite[] objectIcons;
    public int currentId;
    public int buttonId;
    public int objectId;
    public Transform spawnPoint;
    public Button[] buttons;
    public Texture[] icons;
    public Image[] buttonImage;

    List<GameObject> spawnList;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();

        spawnList = new List<GameObject>();
        for (int i = 0; i < buttons.Length; i++)
        {
            int numObj = Random.Range(0, objetsToSpawn.Length);
            GameObject obj = objetsToSpawn[numObj];
            spawnList.Add(obj);

            buttons[i].GetComponent<Image>().sprite = objectIcons[numObj];
        }
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
        //currentId = Random.Range(0, objetsToSpawn.Length);
        GameObject newObj = spawnList[buttonId];
        GameObject objectSpawned = Instantiate(newObj, spawnPoint.position, Quaternion.identity);
        buttons[buttonId].interactable = false;

        if (gameManager.currentObject != null)
        {
            gameManager.currentObject.GetComponent<BlockController>().enabled = false;
        }

        gameManager.currentObject = objectSpawned;
    }
}
