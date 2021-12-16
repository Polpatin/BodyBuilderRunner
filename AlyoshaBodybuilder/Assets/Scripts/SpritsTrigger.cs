using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RunAlex;
public class SpritsTrigger : MonoBehaviour
{
    public static int steroidsMiliGramm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        steroidsMiliGramm = steroidsMiliGramm + 10;
        if(steroidsMiliGramm>150)
        {
            SteroidsOverdose();
        }
       // Debug.Log("Sprits Destroyed");
    }
    void SteroidsOverdose()
    {
        SceneManager.LoadScene(2);
    }

}
