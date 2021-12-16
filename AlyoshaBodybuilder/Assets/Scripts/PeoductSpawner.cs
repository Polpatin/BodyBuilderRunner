using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeoductSpawner : MonoBehaviour
{
    private float leftSpavnBorder = -2.18f;
    private float rightSpavnBorder = 2.18f;
    public GameObject[] productPrefabs;
    private float spawnPositionY = -9f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandpmProduct", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandpmProduct()
    {
        int randomIndex = Random.Range(0, productPrefabs.Length);
        Vector2 spawnPos = new Vector2(Random.Range(leftSpavnBorder, rightSpavnBorder), spawnPositionY);
        Instantiate(productPrefabs[randomIndex], spawnPos , productPrefabs[randomIndex].transform.rotation);
    }
}
