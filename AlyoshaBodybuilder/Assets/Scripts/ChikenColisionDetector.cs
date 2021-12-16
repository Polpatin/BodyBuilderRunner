using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using RunAlex;
public class ChikenColisionDetector : MonoBehaviour
{
    
    public static int proteinCallories;
    // Start is called before the first frame update
    void Start()
    {
      //  proteinSlider.value = proteinCallories;
    }

    // Update is called once per frame
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Chiken Destroyed "+proteinCallories);
        proteinCallories = proteinCallories+150;
        if (proteinCallories > 3000)
        {
            ProteinOverdose();
        }
        // Debug.Log("Sprits Destroyed");
    }
    void ProteinOverdose()
    {
        SceneManager.LoadScene(4);
    }
}

