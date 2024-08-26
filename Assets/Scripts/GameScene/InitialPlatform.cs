using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialPlatform : MonoBehaviour
{
   void OnTriggerExit(Collider other)
    {        
        Destroy(gameObject, 3f);
    }
}
