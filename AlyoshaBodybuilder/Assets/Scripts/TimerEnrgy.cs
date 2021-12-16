using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RunAlex;
public class TimerEnrgy : MonoBehaviour
{
    static int  time;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimeEnergy", 5f, 3f);
        InvokeRepeating("AllSuplementsOnTop", 3f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
     void TimeEnergy()
    {
        ChikenColisionDetector.proteinCallories = ChikenColisionDetector.proteinCallories - 20;
        RisColisionDetector.carbohydratesCalories = RisColisionDetector.carbohydratesCalories - 20;
        BurgerTrigger.fatCalories = BurgerTrigger.fatCalories - 20;
        Debug.Log("Time is runing "+ time++);

    }

    void AllSuplementsOnTop()
    {
        Debug.Log("Win Courutin is Worcking");
        if(ChikenColisionDetector.proteinCallories>1000 )
        {
            if (RisColisionDetector.carbohydratesCalories>1000 )
            {
                if(BurgerTrigger.fatCalories>1000 )
                {
                    if(SpritsTrigger.steroidsMiliGramm>100 )
                    {
                        SceneManager.LoadScene(6);
                    }
                }
            }
        }
    }
}
