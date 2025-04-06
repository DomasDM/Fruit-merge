using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private string inthecloud = "y";
    void Start()
    {
        if (transform.position.y < 3.5)
        {
            inthecloud = "n";
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
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
            cloundcont.spawnPos = transform.position;
            cloundcont.newfruit = "y";
            cloundcont.whichFruit = int.Parse(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
