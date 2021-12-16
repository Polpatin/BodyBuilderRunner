using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RunAlex;
public class SteroidsSlider : MonoBehaviour
{
    public Slider steroidsSlider;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        steroidsSlider.value = SpritsTrigger.steroidsMiliGramm;
    }
}
