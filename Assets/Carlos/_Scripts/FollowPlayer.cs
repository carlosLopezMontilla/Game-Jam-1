using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] public Transform player;
    [SerializeField] public float distance;
    private Vector3 initialCameraPos;

    private void Start()
    {
        initialCameraPos.y = transform.position.y;
        initialCameraPos.z = transform.position.z;
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + distance, initialCameraPos.y, initialCameraPos.z);
    }
}

