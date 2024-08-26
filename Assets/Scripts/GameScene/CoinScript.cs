using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed, 0f, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LogicScript.instance.addScore();
            Destroy(gameObject);
        }
    }
}
