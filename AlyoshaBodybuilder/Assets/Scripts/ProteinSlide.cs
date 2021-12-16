using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace RunAlex
{
    public class ProteinSlide : MonoBehaviour
    {
        public  Slider ProteinSlider;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            ProteinSlider.value =ChikenColisionDetector. proteinCallories;
        }
    }
}