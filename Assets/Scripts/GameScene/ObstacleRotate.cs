using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 6f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed, Space.Self);
    }
}
