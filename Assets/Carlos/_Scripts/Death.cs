using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
            //Destroy(other.gameObject, 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
           
    }
}
