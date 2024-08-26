using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetectioin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            LogicScript.instance.ShowGameOverPanel("Crash");
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("BlueVortex"))
        {
            LogicScript.instance.ShowGameOverPanel("Vortex");
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("BlackHole"))
        {
            LogicScript.instance.ShowGameOverPanel("BlackHole");
            Destroy(gameObject);
        }
    }
}
