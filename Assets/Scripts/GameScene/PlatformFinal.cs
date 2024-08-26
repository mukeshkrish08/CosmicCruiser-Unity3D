using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFinal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject obstacle1;
    [SerializeField] GameObject obstacle2;

    [SerializeField] GameObject coin;
    void Start()
    {
        SpawnObstacle();
        SpawnCoins();
    }
    
    private void OnTriggerExit(Collider other)
    {
        LogicScript.instance.SpawnPlatform();
        Destroy(gameObject, 3f);
    }

    void SpawnObstacle()
    {
        HashSet<int> selectedIndices = new HashSet<int>();
        int numberOfIndicesToSelect = 3;

        // Fill the HashSet with unique random indices
        while (selectedIndices.Count < numberOfIndicesToSelect)
        {
            int rand = Random.Range(2, 13); // Generate a random index in the range
            selectedIndices.Add(rand); // Add it to the set (ensures uniqueness)
        }

        // Iterate over each unique index in the HashSet
        foreach (int rand in selectedIndices)
        {
            GameObject selectedObstacle = Random.Range(0, 2) == 0 ? obstacle1 : obstacle2;
            Transform spawnpoint = transform.GetChild(rand);
            Instantiate(selectedObstacle, spawnpoint.position, Quaternion.identity, transform);
            Debug.Log("Item spawned at: " + spawnpoint.position);
        }
    }
    void SpawnCoins()
    {
        HashSet<int> selectedIndices = new HashSet<int>();
        int numberOfIndicesToSelect = 6;

        while (selectedIndices.Count < numberOfIndicesToSelect)
        {
            int rand = Random.Range(13, 21); // Generate a random index in the range
            selectedIndices.Add(rand); // Add it to the set (ensures uniqueness)
        }

        foreach (int rand in selectedIndices)
        {
            Transform spawnpoint = transform.GetChild(rand);
            Instantiate(coin, spawnpoint.position, coin.transform.rotation, transform);
            Debug.Log("Coin spawned at: " + spawnpoint.position);
        }
    }
}

