using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Back ButtonCliked");
        ClearProgress();
    }
    void ClearProgress()
    {
        ChikenColisionDetector.proteinCallories = 0;
        RisColisionDetector.carbohydratesCalories = 0;
        BurgerTrigger.fatCalories = 0;
        SpritsTrigger.steroidsMiliGramm = 0;
        Debug.Log("Progress Reseted");
    }
}
