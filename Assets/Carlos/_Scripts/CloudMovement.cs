using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private void Update()
    {
        float movSpeed = 0.25f;
        transform.position += new Vector3(-movSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x < -25)
            transform.position += new Vector3(50, 0, 0);
    }
}
