using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBorders : MonoBehaviour
{
    private float topBorderY = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>topBorderY)
        {
            Destroy(gameObject);
        }
    }
}
