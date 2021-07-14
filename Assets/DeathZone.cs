using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public Transform pointToSpawn;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //other.transform.position = pointToSpawn.position;
            SceneManager.LoadScene(1);
        }
    }
}
