using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string inthecloud = "y";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inthecloud=="y")
        {
            GetComponent<Transform>().position = cloundcont.cloudxPos;
        }
        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            inthecloud = "n";
            cloundcont.spawnedYet = "n";
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            Destroy(gameObject);
        }
    }
}
