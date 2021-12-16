using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorders : MonoBehaviour
{
    private float leftBorderX=-1.9f;
    private float rightBorderX=2.09f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBorderX)
        {
            transform.position = new Vector2(leftBorderX, transform.position.y);
        }
        if(transform.position.x>rightBorderX)
        {
            transform.position = new Vector2(rightBorderX, transform.position.y);
        }
    }
}
