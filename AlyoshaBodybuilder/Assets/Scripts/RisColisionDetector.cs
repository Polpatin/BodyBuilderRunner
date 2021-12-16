using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RisColisionDetector : MonoBehaviour
{
    public static int carbohydratesCalories;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        carbohydratesCalories = carbohydratesCalories + 100;
        //Debug.Log("Ris Destroyed");
        if (carbohydratesCalories > 3000)
        {
            CarboOverdose();
        }
        // Debug.Log("Sprits Destroyed");
    }
    void CarboOverdose()
    {
        SceneManager.LoadScene(3);
    }

}

