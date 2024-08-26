using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        if (player != null)
        {
            offset = transform.position - player.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + offset;
            //targetPosition.x = 125;
            transform.position = targetPosition;
        } 
    }
}

