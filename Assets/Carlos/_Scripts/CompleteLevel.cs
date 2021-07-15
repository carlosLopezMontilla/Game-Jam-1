using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public GameObject bouncyBall;
    public GameObject completeLevelFade;
    public GameObject endText;

    private void OnTriggerStay(Collider other)
    {
       
            bouncyBall.SetActive(true);
            Destroy(other.gameObject, 0);
            completeLevelFade.SetActive(true);
            endText.SetActive(true);
           
        
    }
}
