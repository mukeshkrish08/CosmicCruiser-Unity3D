using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] float rotateSpeedYAxis = 4f;
    [SerializeField] float rotateSpeedXAxis = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeedYAxis * Time.deltaTime);
        transform.Rotate(-Vector3.right, rotateSpeedXAxis * Time.deltaTime);
    }
}
