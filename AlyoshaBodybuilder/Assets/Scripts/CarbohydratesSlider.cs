using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RunAlex;
public class CarbohydratesSlider : MonoBehaviour
{
    public Slider carbohydratesSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        carbohydratesSlider.value = RisColisionDetector.carbohydratesCalories;

    }
}
