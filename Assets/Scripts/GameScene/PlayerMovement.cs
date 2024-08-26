using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody rigidBody;
    [SerializeField] float baseSpeed, horizontalMultiplier;
    [SerializeField] float horizontalInput;
    [SerializeField] float distanceTraveled;
    [SerializeField] float currentSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        currentSpeed = baseSpeed + (distanceTraveled * 0.020f);
        currentSpeed = Mathf.Min(currentSpeed, 160f);
        Vector3 forwardMove = transform.forward * currentSpeed * Time.fixedDeltaTime;
        Vector3 horizontalmove = transform.right * horizontalInput * Time.fixedDeltaTime * horizontalMultiplier;
        rigidBody.MovePosition(rigidBody.position + forwardMove + horizontalmove);
        distanceTraveled += forwardMove.magnitude;
    }
}  