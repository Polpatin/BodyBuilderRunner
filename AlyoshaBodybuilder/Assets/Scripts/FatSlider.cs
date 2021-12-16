using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FatSlider : MonoBehaviour
{
    public Slider fatSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fatSlider.value = BurgerTrigger.fatCalories;
    }
}
