using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using RunAlex;
public class BurgerTrigger : MonoBehaviour
{
    public static int fatCalories;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        fatCalories = fatCalories + 100;
        //Debug.Log("Sprits Destroyed");
        if (fatCalories > 3000)
        {
            FatOverdose();
        }
        // Debug.Log("Sprits Destroyed");
    }
    void FatOverdose()
    {
        SceneManager.LoadScene(4);
    }


}
