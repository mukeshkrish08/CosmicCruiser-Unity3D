using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 6f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed, 0f, Space.Self);
    }
}
